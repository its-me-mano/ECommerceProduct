
using ECommerceProduct.Entities.Dto;
using ECommerceProduct.Entities.Model;
using ECommerceProduct.Helper;
using System;
using System.Collections.Generic;

namespace ECommerceProduct.Contracts
{
    public interface IProductServices
    {
        /// <summary>
        /// Get all the products
        /// </summary>
        /// <param name="userResourceParameter"></param>
        /// <returns></returns>
        PageList<Product> GetProducts(UserResourceParameter userResourceParameter,string role);
        /// <summary>
        /// Get the products by ids
        /// </summary>
        /// <param name="guids"></param>
        /// <returns></returns>
        IEnumerable<Product> GetProductsByIds(String guids);

        /// <summary>
        /// Set visibility for the product
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        void SetVisibility(Guid userId);
        /// <summary>
        /// Check the product is in the database or not
        /// </summary>
        /// <param name="userId"></param>
        bool CheckProduct(Guid userId);
        /// <summary>
        /// Return productDto after adding values
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        void  SetValuesToProduct(string increment,string decrement,string value,ProductDto product, Guid productId);
        /// <summary>
        /// get the product quantity
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        int GetProductCount(Guid productId);
        /// <summary>
        /// Get the particular product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Product GetProduct(Guid productId);
        /// <summary>
        /// Delete the product
        /// </summary>
        /// <param name="productId"></param>
        void DeleteProduct(Guid productId);
    }
}
