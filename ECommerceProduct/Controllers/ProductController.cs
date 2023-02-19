using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using ECommerceProduct.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using ECommerceProduct.Entities.Model;
using ECommerceProduct.Helper;
using ECommerceProduct.Entities.Dto;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Http;

namespace ECommerceProduct.Controllers
{
    [ApiController]
    [Route("api/account/product")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductServices _service;
        private readonly ILogger _logger;

        public ProductController(IMapper mapper, IProductServices service, ILogger logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _service = service ?? throw new ArgumentException(nameof(mapper));
            _logger = logger ?? throw new ArgumentException(nameof(logger));
        }

        /// <summary>
        /// Get All the products
        /// </summary>
        /// <remarks>Get the all the Products list based on the condition</remarks>
        /// <param name="userResourceParameter"></param>
        /// <response code="200">Products fetched successfully</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="403">user doesn't have permisssion to access this resource</response>
        [Authorize]
        [SwaggerOperation("GetProduct")]
        [SwaggerResponse(statusCode: 200, "All the address book fetched successfully")]
        [SwaggerResponse(statusCode: 401, "The user  is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 403, "user doesn't have permisssion to access this resource")]
        [HttpGet(Name = "GetProduct")]
        public IActionResult GetProductsForUser([Required][FromQuery(Name = "page-no")] int PageNo, [FromQuery(Name = "page-size")] int PageSize, [FromQuery(Name = "order-type")] string OrderType, [FromQuery(Name = "order-by")] string OrderBy, [FromQuery(Name = "search-query")] string searchQuery, [FromQuery(Name = "category")] string Category)
        {
            _logger.LogInformation("Getting the product has been initiated");
            Guid LoggedId = new Guid((User.Claims.Select(Claim => Claim.Value).ToList())[0]);
            UserResourceParameter userResourceParameter = new UserResourceParameter()
            {
                PageNo = PageNo,
                PageSize = PageSize,
                OrderBy = OrderBy,
                OrderType = OrderType,  
                category = Category,
                searchQuery = searchQuery
            };
            String role = User.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList()[0];
            PageList<Product> products = _service.GetProducts(userResourceParameter, role);
            _logger.LogInformation("Products fetched successfully");
            return StatusCode(200,_mapper.Map<IEnumerable<ProductDto>>(products));

        } 

        /// <summary>
        /// Set the Visibility
        /// </summary>
        /// <remarks>In this route,we can set the visibility of the product</remarks>
        /// <response code="200">Changes visibility successfully</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="403">user doesn't have permisssion to access this resource</response>
        [SwaggerOperation("ChangeVisibility")]
        [SwaggerResponse(statusCode: 200, "Changes visibility successfully")]
        [SwaggerResponse(statusCode: 401, "The user  is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 403, "user doesn't have permisssion to access this resource")]
        [Authorize(Roles = "Admin")]
        [HttpPut("{user-id}", Name = "ChangeVisibility")]
        public IActionResult ChangeVisibility([FromRoute(Name = "user-id")][Required] Guid productId) {
            _logger.LogInformation("ChangeVisibiltiy process has been initiated");
            if (_service.CheckProduct(productId))
            {
                _service.SetVisibility(productId);
                _logger.LogInformation("Product visibility changed successfully");
                return Ok("Updated Successfully");
            }
            else {
                _logger.LogError("Cound not find the product Id");
                return StatusCode(404, "Cound not find the product Id");
            }
        }

        /// <summary>
        /// Update the product Quantity
        /// </summary>
        /// <remarks>Update the product Quantity</remarks>
        /// <response code="200">Quantity update successsfully</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="403">user doesn't have permisssion to access this resource</response>
        [SwaggerOperation("UpdateTheQuantity")]
        [SwaggerResponse(statusCode: 200, "Quantity update successsfully")]
        [SwaggerResponse(statusCode: 401, "The user  is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 403, "user doesn't have permisssion to access this resource")]
        [Authorize(Roles ="Admin")]
        [HttpPut("quantity")]
        public IActionResult UpdateTheQuantity([FromQuery(Name = "product-id")] string product1Id, [FromQuery(Name = "increment")] string increment, [FromQuery(Name = "decrement")] string decrement, [FromQuery(Name = "value")] string
            value) {

     
            Guid productId = new Guid(product1Id);
            if (!_service.CheckProduct(productId))
            {
                return StatusCode(404, "There is no product with that productId. Check the productId");
            }
            ProductDto product = new ProductDto();
            product.ProductCount = _service.GetProductCount(productId);
            _service.SetValuesToProduct(increment, decrement, value, product, productId);
            return StatusCode(200, "quantity of the product has been updated");
        }

        /// <summary>
        /// delete product
        /// </summary>
        /// <remarks>delete the product</remarks>
        /// <response code="200">deleted the product</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="403">user doesn't have permisssion to access this resource</response>
        [SwaggerOperation("DeleteProduct")]
        [SwaggerResponse(statusCode: 200, "Deleted the product successfully")]
        [SwaggerResponse(statusCode: 401, "The user  is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 403, "user doesn't have permisssion to access this resource")]
        [Authorize(Roles ="Admin")]
        [HttpDelete("delete/{product-id}")]
        public IActionResult DeleteProduct([Required][FromRoute(Name = "product-id")] Guid productId) {
            if (!_service.CheckProduct(productId))
            {
                return StatusCode(404, "There is no product with that productId. Check the productId");
            }
            _service.DeleteProduct(productId);
            return StatusCode(200, "Product has been deleted successfully");
        }
        /// <summary>
        /// GetProducts
        /// </summary>
        /// <remarks>Get the products</remarks>
        /// <response code="200">fetch the product successfully</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="403">user doesn't have permisssion to access this resource</response>
        [SwaggerOperation("GetProducts")]
        [SwaggerResponse(statusCode: 200, "fetch the product successfully")]
        [SwaggerResponse(statusCode: 401, "The user  is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 403, "user doesn't have permisssion to access this resource")]
        [Authorize]
        [HttpGet("getproducts")]
        public IActionResult GetProductByIds([FromQuery(Name = "queryString")] string guids) {
            IEnumerable<Product> products = _service.GetProductsByIds(guids);
            return StatusCode(200, products);    
        }
        /// <summary>
        /// AddWishList
        /// </summary>
        /// <remarks>Product add to wishlist </remarks>
        /// <response code="200">Deleted the product successfully</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="403">user doesn't have permisssion to access this resource</response>
        [SwaggerOperation("AddWishList")]
        [SwaggerResponse(statusCode: 200, "Deleted the product successfully")]
        [SwaggerResponse(statusCode: 401, "The user  is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 403, "user doesn't have permisssion to access this resource")]
        [Authorize]
        [HttpPost("addwishlist")]
        public IActionResult AddToWishList([FromQuery(Name = "product-id")] string productId,[FromQuery(Name ="wishlist-name")] string wishlistName){
            _logger.LogInformation("Add to wishlist process has been initiated");
             string token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer", "");
            Guid userId = new Guid(_service.GetLoggedId(User));
            _service.AddToWishList(new Guid(productId),token,userId,wishlistName);
            _logger.LogInformation("Product add to wishlist successfully");
            return StatusCode(200, "Product add to wishlist successfully");
        }
        /// <summary>
        /// AddCart
        /// </summary>
        /// <remarks>Proudct add to cart</remarks>
        /// <response code="200">Proudct add to cart successfully</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="403">user doesn't have permisssion to access this resource</response>
        [SwaggerOperation("AddCart")]
        [SwaggerResponse(statusCode: 200, "Proudct add to cart successfully")]
        [SwaggerResponse(statusCode: 401, "The user  is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 403, "user doesn't have permisssion to access this resource")]
        [Authorize]
        [HttpPost("addcart")]
        public IActionResult AddToCart([FromQuery(Name = "product-id")] string productId, [FromQuery(Name = "quantity")] int quantity) {
            _logger.LogInformation("Adding to cart process has been initiated");
            string token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer", "");
            _service.AddToCart(new Guid(productId), quantity,token);
            return StatusCode(200, "Product add to cart successfully");
        }
        /// <summary>
        /// ProductCountCehck
        /// </summary>
        /// <remarks>Check quantiyt of the product</remarks>
        /// <response code="200">Product count checked</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="403">user doesn't have permisssion to access this resource</response>
        [SwaggerOperation("ProductCountCheck")]
        [SwaggerResponse(statusCode: 200, "Product count checked")]
        [SwaggerResponse(statusCode: 401, "The user  is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 403, "user doesn't have permisssion to access this resource")]
        [Authorize]
        [HttpGet("countcheck")]
        public IActionResult CheckProductCount([FromQuery(Name = "quantity")] int quantity, [FromQuery(Name = "product-id")] string productId)
        {
            _logger.LogInformation("Checking product count has been initiated");
           bool check=_service.CheckProdcutCount(quantity, new Guid(productId));
            return StatusCode(200, check);
        }

    }
}


