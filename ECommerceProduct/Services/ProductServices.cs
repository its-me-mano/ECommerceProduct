using AutoMapper;
using ECommerceProduct.Contracts;
using ECommerceProduct.Entities.Dto;
using ECommerceProduct.Entities.Model;
using ECommerceProduct.Helper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

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
        public void SetVisibility(Guid userId) {
            Product product = _productRepositories.GetProduct(userId);
            Guid ChangedId = _productRepositories.ChangeVisibilityId(product.Visibility);
            product.Visibility = ChangedId;
            _productRepositories.UpdateProduct(product, userId);
            _productRepositories.Save();
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

