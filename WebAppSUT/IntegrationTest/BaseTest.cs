using EPShope.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using ProductDataApi.Data;
using ProductDataApi.Repository;
using System;

namespace BddWebSUT.IntegrationTest
{
    public class BaseTest
    {
        public WebApplicationFactory<Program> _factory;
        private ServiceProvider _serviceProvider;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.RemoveAll(typeof(DbContextOptions<ProductDbContext>));
                    services.AddDbContext<ProductDbContext>(option =>
                    {
                        option.UseInMemoryDatabase("InMemoryProductApi");
                    });
                    services.AddTransient<IProductRepository, ProductRepository>();


                    _serviceProvider = services.BuildServiceProvider();
                });


            });
        }

        [OneTimeTearDown]
        public void TearDown() => _factory.Dispose();
        [SetUp]
        public void Setup()
        {
            using (var scope = _factory.Services.CreateScope())
            {
                var scopeService = scope.ServiceProvider;
                var dbContext = scopeService.GetRequiredService<ProductDbContext>();
                try
                {
                    dbContext.Database.EnsureCreated();
                    dbContext.Products.Add(new Product
                    {
                        Name = "New iphone Test",
                        ProductType = ProductType.Iphone,
                        Price = 300,
                        Discription = "bla bla bla",
                        Datetime = DateTime.Now,
                    });
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    //logger
                }
            }
        }
        protected T GetService<T>() => _serviceProvider.GetRequiredService<T>();



    }
}
