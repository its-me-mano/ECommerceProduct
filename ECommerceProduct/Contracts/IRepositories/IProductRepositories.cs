using ECommerceProduct.Entities.Model;
using ECommerceProduct.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProduct.Contracts
{
    public interface IProductRepositories
    {
        /// <summary>
        /// Get the all products
        /// </summary>
        /// <param name="userResourceParameter"></param>
        /// <returns></returns>
        PageList<Product> GetProducts(UserResourceParameter userResourceParameter,string role);
        /// <summary>
        /// Get the particular product
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Product GetProduct(Guid userId);
        /// <summary>
        /// Check the productQuanity is available or not
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        bool CheckProdcutCount(int quantity,Guid productId);
        /// <summary>
        /// It will give the opposite of the current visibility id
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Guid ChangeVisibilityId(Guid id);
        /// <summary>
        /// Update the product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="userId"></param>
        void UpdateProduct(Product product, Guid userId);
        /// <summary>
        /// Check the product in the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool CheckProduct(Guid userId);
        /// <summary>
        /// get the product quantity
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        int GetProductCount(Guid productId);
        /// <summary>
        /// Delete the product
        /// </summary>
        /// <param name="productId"></param>
        void DeleteProduct(Product product);

        ///<summary>
        ///save the context
        ///</summary>
        bool Save();
    }
}
