using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicate.Modbus
{
    public abstract class ModbusBase
    {
        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        public virtual bool Open() 
        {
            return false;
        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        public virtual void Close()
        {

        }
        /// <summary>
        /// 读取无符号单精度数据
        /// </summary>
        /// <param name="startAddress">起始地址</param>
        /// <param name="slaveAddress">从站地址</param>
        /// <param name="funcCode">功能码</param>
        /// <param name="len">读取长度</param>
        /// <returns></returns>
        public virtual Task<List<ushort>> ReadUInt16(byte startAddress,byte slaveAddress=1,byte funcCode=3,ushort len = 1)
        {
            return null;
        }
        /// <summary>
        /// 发送报文
        /// </summary>
        /// <param name="command">报文内容</param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public virtual Task<List<byte>> Send(List<byte> command,int len)
        {
            return null;
        }
        /// <summary>
        /// 组装请求报文
        /// </summary>
        /// <param name="startAddress">起始地址</param>
        /// <param name="slaveAddress">从站地址</param>
        /// <param name="funcCode">功能码</param>
        /// <param name="len">读取长度</param>
        /// <returns></returns>
        protected List<byte> GetReadCommandBytes(byte startAddress, byte slaveAddress, byte funcCode, ushort len)
        {
            List<byte> readCommandBytes = new List<byte>();
            //插入从站、功能码
            readCommandBytes.Add(slaveAddress);
            readCommandBytes.Add(funcCode);
            //根据计算机大小端存储方式进行高低字节装换
            readCommandBytes.Add(BitConverter.GetBytes(startAddress)[1]);
            readCommandBytes.Add(BitConverter.GetBytes(startAddress)[0]);
            readCommandBytes.Add(BitConverter.GetBytes(len)[1]);
            readCommandBytes.Add(BitConverter.GetBytes(len)[0]);
            return readCommandBytes;
        }
        /// <summary>
        /// 组装写入单寄存器报文
        /// </summary>
        /// <param name="startAddress">起始地址</param>
        /// <param name="slaveAddress">从站地址</param>
        /// <param name="funcCode">功能码</param>
        /// <param name="value">需要写入的值</param>
        /// <returns></returns>
        protected List<byte> GetWriteCommandBytes(int startAddress, byte slaveAddress, byte funcCode,ushort value) 
        {
            List<byte> readCommandBytes = new List<byte>();
            //插入从站、功能码
            readCommandBytes.Add(slaveAddress);
            readCommandBytes.Add(funcCode);
            //根据计算机大小端存储方式进行高低字节装换
            readCommandBytes.Add(BitConverter.GetBytes(startAddress)[1]);
            readCommandBytes.Add(BitConverter.GetBytes(startAddress)[0]);
            readCommandBytes.Add(BitConverter.GetBytes(value)[1]);
            readCommandBytes.Add(BitConverter.GetBytes(value)[0]);
            return readCommandBytes;
        }
        /// <summary>
        /// 将响应报文数据部分(byte列表)转化为(ushort列表)
        /// </summary>
        /// <param name="datas">响应报文的数据部分</param>
        /// <returns></returns>
        protected List<ushort> ReadUint16(List<byte> datas)
        {
            List<ushort> ushortList = new List<ushort>();
            //将读取到的每一个数据(byte类型)转为ushort类型
            for (int i = 0; i < datas.Count; i++)
            {
                List<byte> valueByte = new List<byte>();
                valueByte.Add(datas[i]); 
                valueByte.Add(datas[++i]);
                valueByte.Reverse();
                ushort value = BitConverter.ToUInt16(valueByte.ToArray(), 0);
                ushortList.Add(value);
            }
            return ushortList;
        }
        /// <summary>
        /// 写入寄存器
        /// </summary>
        /// <param name="startAddress">起始地址</param>
        /// <param name="value">需要写入的值</param>
        /// <param name="slaveAddress">从站地址</param>
        /// <param name="funcCode">功能码：06写单寄存器</param>
        /// <returns></returns>
        public virtual Task<bool> WriteUInt16(int startAddress, ushort value,byte slaveAddress=1,byte funcCode =  6)
        {
            return null;
        }
    }
}
