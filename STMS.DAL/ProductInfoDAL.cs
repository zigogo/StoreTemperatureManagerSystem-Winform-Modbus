using Common;
using STML.Models.DModels;
using STMS.DAL.Base;
using STMS.DbUtility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL
{
    public class ProductInfoDAL:BaseDAL<ProductInfo>
    {
        /// <summary>
        /// 根据查询条件返回产品信息
        /// </summary>
        /// <param name="wordOfSearch">查询关键字</param>
        /// <param name="isDeleted">是否已删除</param>
        /// <returns></returns>
        public List<ProductInfo> GetProductInfos(string wordOfSearch, int isDeleted)
        {
            string cols = CreateSql.GetColsString<ProductInfo>("IsDeleted");
            string strWhere = $"IsDeleted={isDeleted}";
            if (!string.IsNullOrEmpty(wordOfSearch))
            {//有查询条件
                strWhere += " and (ProductNo like @wordOfSearch or ProductName like @wordOfSearch) ";
                SqlParameter sqlParameter = new SqlParameter("@wordOfSearch", wordOfSearch);
                return GetModelList(strWhere, cols, sqlParameter);
            }
            else
                return GetModelList(cols, isDeleted);//Where is null
        }

        /// <summary>
        /// 获取指定产品ID的产品信息
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public ProductInfo GetProduct(int ProductId)
        {
            //string cols = "StoreNo,StoreName,Remark";
            string cols = CreateSql.GetColsString<ProductInfo>("IsDeleted");
            return GetById(ProductId, cols);
        }

        /// <summary>
        /// 获取所有仓库信息( 作为下拉框的数据)
        /// </summary>
        /// <returns></returns>
        public List<ProductInfo> GetAllProduct()
        {
            return GetModelList("ProductId,ProductName", 0);
        }
        /// <summary>
        /// 获取指定产品ProductId的库存数
        /// </summary>
        /// <returns></returns>
        public int GetStockCount(int productId)
        {
            string sql = $"select sum(ProductCount) from ProductStoreInfos where ProductId = {productId} ";
            object oCount = SqlHelper.ExecuteScalar(sql, 1);
            if (oCount != null && oCount.ToString() != "")
                return oCount.GetIntOrZero();
            return 0;
        }

        /// <summary>
        /// 判断ProductName和ProductNo是否已经存在
        /// </summary>
        /// <param name="ProductName"></param>
        /// <param name="ProductNo"></param>
        /// <returns>bool类型数组 第一个为StoreName，第二个为StoreNo</returns>
        public bool[] IsExistsProduct(string ProductName, string ProductNo)
        {
            bool isExistsProductName = false;
            if (!string.IsNullOrEmpty(ProductName))//传空值就返回false
                isExistsProductName = ExistsByName("ProductName", ProductName);
            bool isExistsProductNo = false;
            if (!string.IsNullOrEmpty(ProductNo))//传空值就返回false
                isExistsProductNo = ExistsByName("ProductNo", ProductNo);
            return new bool[] { isExistsProductName, isExistsProductNo };
        }
        /// <summary>
        /// 添加产品信息
        /// </summary>
        /// <param name="productInfo"></param>
        /// <returns>返回新添加产品的ProductId</returns>
        public int AddProduct(ProductInfo productInfo)
        {
            string cols = "ProductName,ProductNo,FitLowTemperature,FitHighTemperature";
            return Add(productInfo, cols, 1);
        }
        /// <summary>
        /// 更新产品信息
        /// </summary>
        /// <param name="productInfo"></param>
        /// <returns>返回是否更新成功</returns>
        public bool UpdateProduct(ProductInfo productInfo)
        {
            string cols = CreateSql.GetColsString<ProductInfo>("IsDeleted");
            return Update(productInfo, cols);
        }

    }
}
