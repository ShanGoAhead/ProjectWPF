using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{

    public class ProductManager
    {
        //创建商品数据访问对象
        private ProductService objProductService = new ProductService();

        //获取商品分类
        public List<ProductCategory> GetAllCategory()
        {
            return objProductService.GetAllCategory();
        }

        //获取商品单位
        public string[] GetAllUnit()
        {
            return objProductService.GetAllUnit();
        }
        /// <summary>
        /// 添加商品信息(调用带参数的存储过程)
        /// </summary>
        /// <param name="objProduct"></param>
        /// <returns></returns>
        public int AddProduct(Products objProduct)
        {
            return objProductService.AddProduct(objProduct);
        }

        //根据商品编号获取商品信息
        public Products GetProductById(string ProductId)
        {
            return objProductService.GetProductById(ProductId);
        }

        //商品入库同时更新商品库存信息（调用带参数的存储过程）
        public int Updatelnventory(string productId, string addedCount)
        {
            return objProductService.Updatelnventory(productId, addedCount);
        }

        /// <summary>
        /// 根据组合条件查询商品和库存信息
        /// </summary>
        /// <param name="productId">商品编号</param>
        /// <param name="productName">商品名称</param>
        /// <param name="categoryId">分类编号</param>
        /// <returns>返回商品的DataTable</returns>
        public DataTable QueryInventoryInfo(string productId, string productName, string categoryId)
        {
            if (categoryId != "-1")
            {
                return objProductService.QueryInventoryInfo(productId, productName, categoryId);
            }
            else
            {
                return objProductService.QueryInventoryInfo(productId, productName, "");
            }
        }
        /// <summary>
        /// 查询库存预警综合信息
        /// </summary>
        /// <param name="totalCount">返回参数：预警商品总数量</param>
        /// <param name="maxCount">返回参数：超出库存上限商品总数</param>
        /// <param name="minCount">返回参数：低于库存下限商品总数</param>
        /// <returns>返回库存预警商品信息</returns>
        public List<Products> QueryWarningInfo(out int totalCount, out int maxCount, out int minCount)
        {
            return objProductService.QueryWarningInfo(out totalCount, out maxCount, out minCount);
        }

        //查询高于库存上限的商品信息
        public DataTable QueryInventoryMax()
        {
            return objProductService.QueryInventoryMax();
        }
        //查询低于库存下限的商品信息
        public DataTable QueryInventoryMin()
        {
            return objProductService.QueryInventoryMin();
        }

        //更新商品最大库存和最小库存
        public int UpdateInventory(string productId, string maxCount, string minCount)
        {
            return objProductService.UpdateInventory(productId, maxCount, minCount);
        }
        //根据商品编号更新商品折扣
        public int UpdateDiscount(string productId, string discount)
        {
            return objProductService.UpdateDiscount(productId, discount);
        }
        //更新商品当前库存
        public int UpdateTotalCount(string totalcount, string productId)
        {
            return objProductService.UpdateTotalCount(totalcount, productId);
        }
        //修改商品
        public int EditProduct(Products objProduct)
        {
            return objProductService.EditProduct(objProduct);
        }
        //删除商品根据编号
        public int DeleteProduct(string productId)
        {
          return   objProductService .DeleteProduct (productId);
        }
    }
}
