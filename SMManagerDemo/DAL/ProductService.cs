using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 商品数据访问类
    /// </summary>
    public class ProductService
    {
        //获取商品分类
        public List<ProductCategory> GetAllCategory()
        {
            string sql = "select CategoryId,CategoryName from ProductCategory";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<ProductCategory> list = new List<ProductCategory>();
            while (objReader.Read())
            {
                list.Add(new ProductCategory()
                {
                    CategoryId = Convert.ToInt32(objReader["CategoryId"]),
                    CategoryName = objReader["CategoryName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        //获取商品单位
        public string[] GetAllUnit()
        {
            string sql = "select Unit from ProductUnit";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<string> list = new List<string>();
            while (objReader.Read())
            {
                list.Add(objReader["Unit"].ToString());
            }
            objReader.Close();
            return list.ToArray();
        }

        /// <summary>
        /// 添加商品信息(调用带参数的存储过程)
        /// </summary>
        /// <param name="objProduct">商品对象</param>
        /// <returns></returns>
        public int AddProduct(Products objProduct)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                    new SqlParameter ("@ProductId",objProduct .ProductId),
                    new SqlParameter ("@ProductName",objProduct .ProductName),
                    new SqlParameter ("@Unit",objProduct .Unit),
                    new SqlParameter ("@UnitPrice",objProduct .UnitPrice),
                    new SqlParameter ("@MaxCount",objProduct .MaxCount),
                    new SqlParameter ("@MinCount",objProduct .MinCount),
                    new SqlParameter ("@CategoryId",objProduct .CategoryId)
            };
            //调用带参数的存储过程更新商品信息
            return SQLHelper.UpdateByProcedure("usp_AddProduct", param);
        }

        //商品入库同时更新商品库存信息（调用带参数的存储过程）
        public int Updatelnventory(string productId,string addedCount)
        {
            SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter ("@ProductId",productId),
                    new SqlParameter("@AddedCount",addedCount)
                };
            return SQLHelper.UpdateByProcedure("usp_UpdateInventory", param);
        }

        //根据商品编号获取商品信息
        public Products GetProductById(string ProductId)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@ProductId",ProductId)
            };
            SqlDataReader objReader = SQLHelper.GetReaderByProcedure("usp_GetProductById",param);
            Products objProducts = null;
            if (objReader.Read())
            {
                objProducts = new Products()
                {
                    ProductId =objReader["ProductId"].ToString (),
                    ProductName = objReader["ProductName"].ToString(),
                    UnitPrice =Convert.ToDecimal (objReader["UnitPrice"]),
                    CategoryId =Convert.ToInt32 (objReader["CategoryId"]),
                    CategoryName =objReader["CategoryName"].ToString (),
                    Unit = objReader["Unit"].ToString ()
                };
            }
            objReader.Close();
            return objProducts;
        }

        /// <summary>
        /// 根据组合条件查询商品和库存信息
        /// </summary>
        /// <param name="productId">商品编号</param>
        /// <param name="productName">商品名称</param>
        /// <param name="categoryId">分类编号</param>
        /// <returns>返回商品的DataTable</returns>
        public DataTable  QueryInventoryInfo(string productId, string productName, string categoryId)
        {
            string sql = "select ProductId,ProductName,Unit,UnitPrice,Discount ,TotalCount, MaxCount,MinCount,CategoryId,CategoryName,InventoryStatus";
            sql += " from View_QueryInventoryInfo where 1=1";
            if (productId.Length != 0)
            {
                sql += string.Format(" and ProductId='{0}'", productId);
            }
            if (productName.Length != 0)
            {
                sql += string.Format(" and productName like '%{0}%'", productName);
            }
            if (categoryId.Length  != 0)
            {
                sql += string.Format(" and categoryId='{0}'", categoryId);
            }
            return SQLHelper .GetDataSet(sql).Tables[0];
        }
        /// <summary>
        /// 查询库存预警综合信息
        /// </summary>
        /// <param name="totalCount">返回参数：预警商品总数量</param>
        /// <param name="maxCount">返回参数：超出库存上限商品总数</param>
        /// <param name="minCount">返回参数：低于库存下限商品总数</param>
        /// <returns>返回库存预警商品信息</returns>
        public List<Products> QueryWarningInfo(out int totalCount,out int maxCount,out int minCount)
        {
            //定义3个输出参数
            SqlParameter param_totalCount = new SqlParameter("@totalCount",SqlDbType.Int);
            param_totalCount.Direction = ParameterDirection.Output;
            SqlParameter param_maxCount = new SqlParameter("@maxCount", SqlDbType.Int);
            param_maxCount.Direction = ParameterDirection.Output;
            SqlParameter param_minCount = new SqlParameter("@minCount", SqlDbType.Int);
            param_minCount.Direction = ParameterDirection.Output;
            //把三个参数放到一个数组中
            SqlParameter[] paramArray = new SqlParameter[] { param_totalCount, param_maxCount , param_minCount };
            //调用后台方法，执行带参数的存储过程，并封装查询结果
            SqlDataReader objReader = SQLHelper.GetReaderByProcedure("usp_QueryWarningInfo", paramArray);
            List<Products> list = new List<Products>();
            while (objReader.Read())
            {
                list.Add(new Products()
                {
                    ProductId = objReader["ProductId"].ToString(),
                    ProductName = objReader["ProductName"].ToString(),
                    Unit = objReader["Unit"].ToString(),
                    TotalCount =Convert .ToInt32 (objReader["TotalCount"]),
                    MaxCount = Convert.ToInt32(objReader["MaxCount"]),
                    MinCount = Convert.ToInt32(objReader["MinCount"]),
                    InventoryStatus = objReader["InventoryStatus"].ToString()
                });
            }
            objReader.Close();
            //返回参数
            totalCount = Convert.ToInt32(param_totalCount.Value);
            maxCount = Convert.ToInt32(param_maxCount.Value);
            minCount = Convert.ToInt32(param_minCount.Value);
            //返回结果集
            return list;
        }
        //查询高于库存上限的商品信息
        public DataTable  QueryInventoryMax()
        {
            return SQLHelper.GetDataSetByProcedure ("usp_QueryExceedMax",null).Tables[0];
        }
        //查询低于库存下限的商品信息
        public DataTable QueryInventoryMin()
        {
            return SQLHelper.GetDataSetByProcedure("usp_QueryExceedMin", null).Tables[0];
        }
        //更改商品最大库存和最小库存
        public int UpdateInventory(string productId,string maxCount,string minCount)
        {
            string sql = "Update ProductInventory set MaxCount='{0}',MinCount='{1}' where ProductId='{2}' ";
            sql += string.Format(sql, maxCount, minCount, productId);
            return SQLHelper.Update(sql);
        }

        //根据商品编号更新商品折扣
        public int UpdateDiscount(string productId, string discount)
        {
            string sql = "update Products set Discount='{0}' where ProductId='{1}'";
            sql = string.Format(sql,discount ,productId);
            return SQLHelper .Update(sql);
        }
        //更新商品当前库
        public int UpdateTotalCount(string totalcount,string productId)
        {
            string sql = "update ProductInventory set TotalCount={0} where ProductId='{1}'";
            sql=string.Format(sql, totalcount,productId);
            return SQLHelper .Update(sql);
        }
        //修改商品
        public int EditProduct(Products objProduct)
        {
            string sql = "update Products set ProductName='{0}',Unit='{1}',UnitPrice={2} where ProductId='{3}' ";
            sql = string.Format(sql, objProduct.ProductName, objProduct.Unit, objProduct.UnitPrice, objProduct.ProductId);
            return SQLHelper .Update (sql);
        }
        //删除商品根据编号
        public int DeleteProduct(string productId)
        {
            string sql = "delete from Products where ProductId='{0}'";
            sql=string.Format(sql, productId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    throw new Exception("该学号被其他数据表引用，不能直接删除该学员对象！");
                else
                    throw new Exception("数据库操作出现异常！具体信息：" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("异常信息内容是：" + ex.Message);
            }
        }
    }
}
