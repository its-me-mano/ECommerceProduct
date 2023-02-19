using AutoMapper;
using ECommerceProduct.Controllers;
using ECommerceProduct.DbContexts;
using ECommerceProduct.InMemoryContext;
using ECommerceProduct.Repositories;
using ECommerceProduct.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Security.Claims;
using Xunit;
using ECommerceProduct.Profiles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Moq;
using ECommerceProduct.Contracts;

namespace UnitTest
{
    public class UnitTest1
    {
        ProductController productController;
        ProductServices productServices;
        ProductRepository productRepository;
        ProductDetailsContext context;
        IMapper _mapper;
        private readonly IConfiguration configuration;
        private ClaimsPrincipal user;
        ProductController Mockcontroller;
        private Guid userId;
        public UnitTest1(){
            configuration = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            userId = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be");

            user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier,userId.ToString()),
                                        new Claim(ClaimTypes.Role,"Admin")
                                        // other required and custom claims
                           }, "TestAuthentication")); ;

            using var services = new ServiceCollection().AddSingleton<IConfiguration>(configuration).BuildServiceProvider();
            context = InMemorydbContext.productDetailsContext();
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder().
            ConfigureLogging((builderContext, loggingBuilder) =>
            {
                loggingBuilder.AddConsole((options) =>
                {
                    options.IncludeScopes = true;
                });
            });
            IHost host = hostBuilder.Build();
            ILogger<ProductController> logger = host.Services.GetRequiredService<ILogger<ProductController>>();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Automapper());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
            productRepository = new ProductRepository(context);
            productServices = new ProductServices(productRepository, configuration,mapper);
            productController = new ProductController(mapper, productServices, logger);
            productController.ControllerContext = new ControllerContext();
            productController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            var mockservice = new Mock<IProductServices>();
            mockservice.Setup(a => a.AddToWishList(new Guid("8de4b55d-80d2-4313-9367-de5c561ef335"), "", userId, "hi"));
            var service = new ServiceCollection();
            service.AddSingleton<IProductServices>(mockservice.Object);
            var serviceProvider = service.BuildServiceProvider();
            Mockcontroller = new ProductController(mapper,serviceProvider.GetService<IProductServices>(),logger);
            Mockcontroller.ControllerContext = new ControllerContext();
            Mockcontroller.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
        }
        [Fact]
        public void GetAllProducts_Ok()
        {
            IActionResult Response = productController.GetProductsForUser(1, 1, "ASC", "Name","","");
            Assert.IsType<ObjectResult>(Response);
        }

        [Fact]
        public void ChangeVisibility_Ok() {
            Guid productId = new Guid("8de4b55d-80d2-4313-9367-de5c561ef335");
            IActionResult Response = productController.ChangeVisibility(productId);
            Assert.IsType<OkObjectResult>(Response);
        }

        [Fact]
        public void ChangeVisibilit_NotFound() {
            Guid productId = new Guid("8de4b55d-80d2-4313-9367-de5c561ef331");
            IActionResult Response = productController.ChangeVisibility(productId);
            Assert.Equal(404, (Response as ObjectResult).StatusCode);
        }

        [Fact]
        public void UpdateQuantity_Ok() {
            string productId = "8de4b55d-80d2-4313-9367-de5c561ef335";
            IActionResult response = productController.UpdateTheQuantity(productId, "1", "1", "1");
            Assert.Equal(200, (response as ObjectResult).StatusCode);
        }

        [Fact]
        public void UpdateQuantity_NotFound()
        {
            string productId = "8de4b55d-80d2-4313-9367-de5c561ef332";
            IActionResult response = productController.UpdateTheQuantity(productId, "1", "1", "1");
            Assert.Equal(404, (response as ObjectResult).StatusCode);
        }

        [Fact]
        public void DeleteProduct_Ok(){
            Guid productId = new Guid("8de4b55d-80d2-4313-9367-de5c561ef335");
            IActionResult response = productController.DeleteProduct(productId);
            Assert.Equal(200, (response as ObjectResult).StatusCode);
        }

        [Fact]
        public void DeleteProduct_NotFound()
        {
            Guid productId = new Guid("8de4b55d-80d2-4313-9367-de5c561ef335");
            IActionResult response = productController.DeleteProduct(productId);
            Assert.Equal(200, (response as ObjectResult).StatusCode);
        }

        [Fact]
        public void GetProductByIds() {
            Guid productId = new Guid("8de4b55d-80d2-4313-9367-de5c561ef335");
            IActionResult response = productController.DeleteProduct(productId);
            Assert.Equal(200, (response as ObjectResult).StatusCode);
        }

        [Fact]
        public void AddToWishList()
        {
            string productId = "8de4b55d-80d2-4313-9367-de5c561ef335";
            IActionResult response = productController.AddToWishList(productId, "name");
            Assert.Equal(200, (response as ObjectResult).StatusCode);
        }

        [Fact]
        public void AddToCart() {
            string productId = "8de4b55d-80d2-4313-9367-de5c561ef335";
            IActionResult response = productController.AddToCart(productId,1);
            Assert.Equal(200, (response as ObjectResult).StatusCode);
        }

        [Fact]
        public void CheckProductCount() {
            string productId = "8de4b55d-80d2-4313-9367-de5c561ef335";
            IActionResult response = productController.CheckProductCount(1,productId);
            Assert.Equal(200, (response as ObjectResult).StatusCode);
        }
    }
}
