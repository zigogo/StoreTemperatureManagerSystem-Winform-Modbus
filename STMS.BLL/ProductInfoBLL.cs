using STML.Models.DModels;
using STMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    public  class ProductInfoBLL
    {
        ProductInfoDAL productInfoDAL =new ProductInfoDAL();
        /// <summary>
        /// 条件查询产品信息列表
        /// </summary>
        /// <param name="wordOfSearch"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<ProductInfo> GetProductInfos(string wordOfSearch, bool isDeleted)
        {
            int numIsDeleted = isDeleted ? 1 : 0;
            return productInfoDAL.GetProductInfos(wordOfSearch, numIsDeleted);
        }

        /// <summary>
        /// 根据ProductId获取产品信息
        /// </summary>
        /// <returns></returns>
        public ProductInfo GetProduct(int productId)
        {
            return productInfoDAL.GetProduct(productId);
        }
        /// <summary>
        /// 获取所有产品信息(作为下拉框的数据)
        /// </summary>
        /// <returns></returns>
        public List<ProductInfo> GetAllProduct()
        {
            return productInfoDAL.GetAllProduct();
        }


        /// <summary>
        /// 判断指定产品是否有库存
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool IsHaveStock(int productId)
        {
            int count = productInfoDAL.GetStockCount(productId);
            if (count > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 根据产品ID进行逻辑删除
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>返回int型  0：删除失败   1：删除成功   2：该仓库添加了分区</returns>
        public int LogicDeleteProduct(int productId)
        {
            //先判断产品是否有库存
            if (IsHaveStock(productId))
                return 2;//该产品有库存
            else
            {
                bool isSuccess = productInfoDAL.Delete(productId, 0, 1);
                if (isSuccess)
                    return 1;//删除成功
                else
                    return 0;//删除失败
            }
        }
        /// <summary>
        /// 批量根据ID进行逻辑删除
        /// </summary>
        /// <param name="productIds"></param>
        /// <returns>返回string类型 
        /// "Y":删除成功  
        /// "0":删除失败  
        /// "1,2,4":表示storeID1,2,4存在分区
        /// </returns>
        /// 都不存在分区才能删除成功
        public string LogicDeleteProduct(List<int> productIds)
        {
            string reString = "";
            foreach (int productId in productIds)
            {
                if (reString.Length > 0)
                    reString += ",";
                if (IsHaveStock(productId))
                    reString += productId.ToString();
            }
            if (reString == "")//全都没有库存
            {
                reString = productInfoDAL.DeleteList(productIds, 0, 1) ? "Y" : "0";
                //"Y":删除成功   "0":删除失败 
            }
            return reString;
        }
        /// <summary>
        /// 恢复产品信息
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool RecoverProduct(int productId)
        {
            return productInfoDAL.Delete(productId, 0, 0);
        }
        /// <summary>
        /// 真删除产品信息
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool DeleteProduct(int productId)
        {
            return productInfoDAL.Delete(productId, 1, 2);
        }
        /// <summary>
        /// 判断ProductName和ProductNo是否已经存在
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productNo"></param>
        /// <returns>0:都不存在  01:Name不存在，No存在  10:Name存在，No不存在  11:都存在</returns>
        public int IsExistsProduct(string productName, string productNo)
        {
            bool[] bools = productInfoDAL.IsExistsProduct(productName, productNo);
            //bools[0]为ProductName
            //bools[1]为ProductNo
            if (bools[0] && bools[1])
                return 3;//都存在
            else if (bools[0] && !bools[1])
                return 2;//ProductName存在
            else if (!bools[0] && bools[1])
                return 1;//ProductNo存在
            else
                return 0;//都不存在
        }
        /// <summary>
        /// 添加产品并返回是否成功
        /// </summary>
        /// <param name="productInfo"></param>
        /// <returns></returns>
        public bool AddProduct(ProductInfo productInfo)
        {
            return productInfoDAL.AddProduct(productInfo)>0;
        }
        /// <summary>
        /// 更新产品并返回是否更新成功
        /// </summary>
        /// <param name="productInfo"></param>
        /// <returns></returns>
        public bool UpdateProduct(ProductInfo productInfo)
        {
            return productInfoDAL.UpdateProduct(productInfo);
        }
    }
}
