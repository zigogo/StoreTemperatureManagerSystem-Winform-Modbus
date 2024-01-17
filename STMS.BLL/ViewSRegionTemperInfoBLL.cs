using Communicate.Modbus;
using STML.Models.DModels;
using STML.Models.UIModels;
using STML.Models.VModels;
using STMS.DAL;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    public class ViewSRegionTemperInfoBLL
    {
        StoreRegionInfoDAL storeRegionInfoDAL = new StoreRegionInfoDAL();
        ViewSRegionTemperInfoDAL viewSRegionTemperInfoDAL = new ViewSRegionTemperInfoDAL();
        /// <summary>
        /// 查询指定仓库StoreId的分区列表StoreReionBoxModel(分区盒子列表)
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public List<StoreRegionBoxModel> GetSRegionBoxModelInfo(int storeId)
        {
            List<ViewSRegionTemperInfo> viewSRegionTemperInfos = viewSRegionTemperInfoDAL.GetSRegionTemperInfoList(storeId);
            //将List<ViewSRegionTemperInfo>转换为List<StoreRegionBoxModel>类型
            return GetSRegionBoxModelList(viewSRegionTemperInfos);

        }
        /// <summary>
        /// 将ViewSRegionTemperInfo转换为StoreRegionBoxModel类型
        /// </summary>
        private List<StoreRegionBoxModel> GetSRegionBoxModelList(List<ViewSRegionTemperInfo> vSRTInfo)
        {
            List<StoreRegionBoxModel> storeRegionBoxModels = new List<StoreRegionBoxModel>();
            if(vSRTInfo != null)
            {
                int i = 0;
                int id = 0;
                foreach (ViewSRegionTemperInfo info in vSRTInfo)
                {
                    string range = "";
                    if (info.AllowLowTemperature == info.AllowHighTemperature && info.AllowHighTemperature == 0)
                        range = "无";
                    else
                        range = info.AllowLowTemperature + " ~ " + info.AllowHighTemperature;
                    if (info.SRTemperature > 0)
                    {
                        if (info.AllowLowTemperature > info.SRTemperature)
                            info.TemperState = 0;//低温异常
                        else if(info.AllowHighTemperature < info.SRTemperature)
                            info.TemperState = 2;//高温异常
                        else
                            info.TemperState = 1;//正常
                    }
                    i += 1;
                    if (i>1)
                        id++;
                    storeRegionBoxModels.Add(new StoreRegionBoxModel()
                    {
                        SId = id,
                        SRgionId = info.SRegionId,
                        SRegionName = info.SRegionName,
                        SRTemper = info.SRTemperature,
                        MaxTemper = info.AllowHighTemperature,
                        MinTemper = info.AllowLowTemperature,
                        TemperRange = range,
                        TemperState = info.TemperState,
                        ProductCount = info.TotalCount
                    });
                }
            }
            return storeRegionBoxModels;
        }
        /// <summary>
        /// 从设备读取分区温度数据并更新到数据库，返回最新的分区温度数据viewSRegionTemperInfos
        /// </summary>
        /// <returns></returns>
        public List<StoreRegionBoxModel> ReadRegionTemperData()
        {
            //获取所有仓库的分区信息ViewSRegionTemperInfo
            List<ViewSRegionTemperInfo> viewSRegionTemperInfos = viewSRegionTemperInfoDAL.GetSRegionTemperInfoList(0);
            //建立连接
            ModbusRTU modbusRTU = new ModbusRTU("COM1", 9600, 8, StopBits.One, Parity.None);
            ushort length = (ushort)viewSRegionTemperInfos.Count;
            if (modbusRTU.Open())
            {
                //向从站请求数据并修改viewSRegionTemperInfos信息
                viewSRegionTemperInfos = Task.Run(async () =>
                {
                    //从设备读取来的仓库温度数据
                    List<ushort> temperList = await modbusRTU.ReadUInt16(0, len: length);
                    if(temperList!=null)
                    {
                        if (temperList.Count > 0)
                        {
                            List<StoreRegionInfo> storeRegionInfos = new List<StoreRegionInfo>();
                            //遍历响应报文数据部分的温度值，然后更新到数据库里
                            for(int i=0; i < temperList.Count;i++)
                            {
                                //第i个仓库分区的温度
                                decimal temper = decimal.Parse(((decimal)temperList[i] / 10).ToString("0.00"));
                                StoreRegionInfo storeRegionInfo = new StoreRegionInfo();
                                storeRegionInfo.SRegionId = viewSRegionTemperInfos[i].SRegionId;
                                storeRegionInfo.SRTemperature = temper;
                                if (temper > 0)
                                {
                                    if (viewSRegionTemperInfos[i].AllowHighTemperature < temper)
                                        storeRegionInfo.TemperState = 2;
                                    else if(viewSRegionTemperInfos[i].AllowLowTemperature > temper)
                                        storeRegionInfo.TemperState = 0;
                                    else
                                        storeRegionInfo.TemperState = 1;
                                    storeRegionInfos.Add(storeRegionInfo);
                                    viewSRegionTemperInfos[i].TemperState = storeRegionInfo.TemperState;
                                    viewSRegionTemperInfos[i].SRTemperature = temper;
                                }
                            }
                            //将读取到的数据更新到数据库
                            bool isSuccess = storeRegionInfoDAL.UpdateSRegionSRTemperature(storeRegionInfos);
                            if (!isSuccess) 
                                return null;
                        }
                        return viewSRegionTemperInfos;
                    }
                    else
                        return null;
                }).Result;
                modbusRTU.Close();
            }
            return GetSRegionBoxModelList(viewSRegionTemperInfos);
        }

        /// <summary>
        /// 将调整后的温度写入设备
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="sRTemperature"></param>
        /// <returns></returns>
        public bool SetSRTemperature(int sId,decimal sRTemperature)
        {
            bool isSuccess = false;
            //建立对象获取连接
            ModbusRTU modbusRTU = new ModbusRTU("COM1", 9600, 8, StopBits.One, Parity.None);
            if (modbusRTU.Open())
            {
                isSuccess=Task.Run(async () =>
                {
                    ushort temperature = (ushort)(sRTemperature * 10);
                    //写单寄存器
                    return await modbusRTU.WriteUInt16(sId, temperature);
                }).Result;
            }
            modbusRTU.Close();
            return isSuccess;
        }
        /// <summary>
        /// 修改指定仓库分区的温度
        /// </summary>
        /// <param name="sRegionId"></param>
        /// <param name="sTemperature"></param>
        /// <returns></returns>
        public bool UpdateSRTemperatureById(int sRegionId,decimal sTemperature)
        {
            return storeRegionInfoDAL.UpdateSRTemperatureById(sRegionId, sTemperature);
        }

    }
}
