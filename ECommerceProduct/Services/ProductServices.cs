using AutoMapper;
using ECommerceProduct.Contracts;
using ECommerceProduct.Entities.Dto;
using ECommerceProduct.Entities.Model;
using ECommerceProduct.Helper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;

namespace ECommerceProduct.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepositories _productRepositories;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        public ProductServices(IProductRepositories productRepositories,IConfiguration config,IMapper mapper)
        {
            _productRepositories=productRepositories ?? throw new ArgumentNullException(nameof(productRepositories));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _config = config;
        }

        public PageList<Product> GetProducts(UserResourceParameter userResourceParameter,string role)
        {
            return _productRepositories.GetProducts(userResourceParameter,role);
        }

        /// <summary>
        /// Set the visibility of the products
        /// </summary>
        /// <param name="userId"></param>
        public void SetVisibility(Guid productId) {
            Product product = _productRepositories.GetProduct(productId);
            Guid ChangedId = _productRepositories.ChangeVisibilityId(product.Visibility);
            product.Visibility = ChangedId;
            _productRepositories.UpdateProduct(product, productId);
            _productRepositories.Save();
        }

        /// <summary>
        /// Adding the product to the wishlist
        /// </summary>
        /// <param name=""></param>
        /// <param name="productId"></param>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <returns></returns> 
        public void AddToWishList(Guid productId, string token, Guid userId,string wishlistName) {
            var Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var content = new StringContent("manoj", Encoding.UTF8, "application/json");
            var value = Client.PostAsJsonAsync($"http://localhost:6551/api/account/wishlist/add/{productId}?wishlist-name={wishlistName}", content);
        }
        /// <summary>
        /// Adding the product to the cart
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        public void AddToCart(Guid productId, int quantity,string token) {
            float price = _productRepositories.GetProduct(productId).Price;
            var Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var content = new StringContent("manoj", Encoding.UTF8, "application/json");
            var value = Client.PostAsJsonAsync($"http://localhost:6551/api/account/order/addproduct/?product-id={productId}&price={price}&quantity={quantity}", content);
        }
        /// <summary>
        /// Check the product is there or not in the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool CheckProduct(Guid userId) {
            return _productRepositories.CheckProduct(userId);
        }
        /// <summary>
        /// Return productDto after adding values
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        public void SetValuesToProduct(string increment,string decrement,string value, ProductDto product,Guid productId) {
            
            Product productFromRepo = _productRepositories.GetProduct(productId);
            _mapper.Map(productFromRepo, product);
            if (!string.IsNullOrWhiteSpace(increment))
            {
                product.ProductCount += int.Parse(increment);
            }
            if (!string.IsNullOrWhiteSpace(decrement))
            {
                product.ProductCount -= int.Parse(decrement);
            }
            if (!string.IsNullOrWhiteSpace(value))
            {
                product.ProductCount = int.Parse(value);
            }
            _mapper.Map(product, productFromRepo);
            _productRepositories.UpdateProduct(productFromRepo,productId);
            _productRepositories.Save();
            
        }

        /// <summary>
        /// get the product quantity
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int GetProductCount(Guid productId)
        {
            return _productRepositories.GetProductCount(productId);
        }
        /// <summary>
        /// Get the  particular product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product GetProduct(Guid productId) {
            return _productRepositories.GetProduct(productId); 
        }
        /// <summary>
        /// Delete the product
        /// </summary>
        /// <param name="productId"></param>
        public void DeleteProduct(Guid productId) {
            _productRepositories.DeleteProduct(_productRepositories.GetProduct(productId));
            _productRepositories.Save();
        }
        /// <summary>
        /// Check the productQuanity is available or not
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool CheckProdcutCount(int quantity, Guid productId) {
            return _productRepositories.CheckProdcutCount(quantity, productId);
        }
        /// <summary>
        /// Get the userid of the user
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public string GetLoggedId(ClaimsPrincipal User)
        {
            string LoggedUserId = String.Empty;
            if (!String.IsNullOrEmpty(ClaimTypes.NameIdentifier))
                LoggedUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return LoggedUserId;
        }

        /// <summary>
        /// Get the products by ids
        /// </summary>
        /// <param name="guids"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetProductsByIds(String guids)
        {
            List<string> Guids =new List<string>(guids.Split("&"));
            List<Product> products = new List<Product>();
            foreach (string id in Guids) {
                products.Add(GetProduct(new Guid(id)));
            }
            return products;
        }
    }
}

