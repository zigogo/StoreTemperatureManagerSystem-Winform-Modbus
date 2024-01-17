using STML.Models.DModels;
using STMS.DAL.Base;
using STMS.DbUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL
{
    public class ProductStoreInfoDAL:BQuery<ProductStoreInfo>
    {
        /// <summary>
        /// 判断产品ProductId是否在仓库分区SRegionId里
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="sRegionId"></param>
        /// <returns></returns>
        public bool IsExistProductStoreRecord(int productId,int sRegionId)
        {
            string strWhere = $"ProductId={productId} and SRegionId = {sRegionId}";
            return Exists(strWhere);
        }
        /// <summary>
        /// 添加产品库存记录  添加入库记录   (该产品第一次在该分区添加)
        /// 1、添加一条产品库存ProductStoreInfo信息
        /// 2、添加一条产品入库PproductInStoreRecordInfos信息
        /// </summary>
        /// <param name="productStore"></param>
        /// <returns></returns>
        public bool AddProductStore(ProductStoreInfo productStore)
        {
            // 1、添加一条产品库存ProductStoreInfo信息
            string cols1 = CreateSql.GetColsString<ProductStoreInfo>("IsDeleted");
            SqlModel SqlModel1 = CreateSql.GetInsertSqlAndParas<ProductStoreInfo>(productStore, cols1,0);
            List<CommandInfo> commandInfos = new List<CommandInfo>();
            commandInfos.Add(new CommandInfo()
            {
                CommandText = SqlModel1.Sql,
                IsProc = false,
                Paras = SqlModel1.SqlParaArray
            });
            //2、添加一条产品入库PproductInStoreRecordInfos信息
            ProductInStoreRecordInfo productInStoreRecordInfo = new ProductInStoreRecordInfo()
            {
                ProductId= productStore.ProductId,
                SRegionId=productStore.SRegionId,
                ProductCount = productStore.ProductCount
            };
            string cols2 = CreateSql.GetColsString<ProductInStoreRecordInfo>("InStoreTime,IsDeleted");
            SqlModel sqlModel2 = CreateSql.GetInsertSqlAndParas<ProductInStoreRecordInfo>(productInStoreRecordInfo, cols2, 0);
            commandInfos.Add(new CommandInfo()
            {
                CommandText= sqlModel2.Sql,
                IsProc = false,
                Paras= sqlModel2.SqlParaArray
            });
            return SqlHelper.ExecuteTrans(commandInfos);
        }
        /// <summary>
        /// 修改产品库存信息  添加入库记录  (该产品不是第一次在该分区添加)
        /// 
        /// </summary>
        /// <param name="productStore"></param>
        /// <returns></returns>
        public bool UpdateProductStore(ProductStoreInfo productStore)
        {
            //修改产品库存信息
            string cols1 = $"Update ProductStoreInfos Set ProductCount = ProductCount + {productStore.ProductCount} Where ProductId ={productStore.ProductId} and SRegionId = {productStore.SRegionId}";
            List<CommandInfo> commandInfos = new List<CommandInfo>();
            commandInfos.Add(new CommandInfo()
            {
                CommandText=cols1,
                IsProc = false,
            });
            //添加入库信息
            ProductInStoreRecordInfo productInStoreRecordInfo = new ProductInStoreRecordInfo()
            {
                ProductId = productStore.ProductId,
                SRegionId = productStore.SRegionId,
                ProductCount = productStore.ProductCount
            };
            string cols2 = CreateSql.GetColsString<ProductInStoreRecordInfo>("InStoreTime,IsDeleted");
            SqlModel sqlModel = CreateSql.GetInsertSqlAndParas<ProductInStoreRecordInfo>(productInStoreRecordInfo , cols2, 0);
            commandInfos.Add(new CommandInfo()
            {
                CommandText =sqlModel.Sql,
                IsProc = false,
                Paras = sqlModel.SqlParaArray

            });
            return SqlHelper.ExecuteTrans (commandInfos);
        }
    }
}
