
using ECommerceProduct.Entities.Dto;
using ECommerceProduct.Entities.Model;
using ECommerceProduct.Helper;
using System;
using System.Collections.Generic;
using System.Security.Claims;

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
        /// Check the productQuanity is available or not
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        bool CheckProdcutCount(int quantity, Guid productId);
        /// <summary>
        /// Adding the product to the wishlist
        /// </summary>
        /// <param name="token"></param>
        /// <param name="productId"></param>
        /// <param name="userId"></param>
        /// <param name="wishlistName"></param>
        /// <returns></returns>
        void AddToWishList(Guid productId,string token,Guid userId,string wishlistName);
        /// <summary>
        /// Adding the product to the cart
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        void AddToCart(Guid productId,int quantity,string token);

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
        /// <summary>
        /// Get the userid of the user
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        string GetLoggedId(ClaimsPrincipal User);
    }
}
