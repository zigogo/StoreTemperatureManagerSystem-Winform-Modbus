using STML.Models.DModels;
using STMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    public class ProductStoreInfoBLL
    {
        ProductStoreInfoDAL productStoreInfoDAL =new ProductStoreInfoDAL();
        /// <summary>
        /// 产品入库
        /// </summary>
        /// <param name="productStoreInfo"></param>
        /// <returns></returns>
        public bool AddProductStoreInfo(ProductStoreInfo productStoreInfo)
        {
            if(productStoreInfoDAL.IsExistProductStoreRecord(productStoreInfo.ProductId,productStoreInfo.SRegionId))
            {
                //该分区已存在该产品：只需要更新产品的库存数

                return productStoreInfoDAL.UpdateProductStore(productStoreInfo);
            }
            else
            {
                //添加一条新的ProductStoreInfo记录
                return productStoreInfoDAL.AddProductStore(productStoreInfo);
            }
        }
    }
}
