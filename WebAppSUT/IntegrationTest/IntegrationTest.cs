using NUnit.Framework;
using ProductDataApi.Data;
using ProductDataApi.Repository;
using Shouldly;
using System.Net.Http.Json;
using WebFrameworkSUT.Helper;

namespace BddWebSUT.IntegrationTest
{
    public class IntegrationTest : BaseTest
    {
        private IProductRepository _productRepository;
        [SetUp]
        public void Setup()
        {
            _productRepository = GetService<IProductRepository>();
        }

        [Test]
        public async Task Integration()
        {
            var client = _factory.CreateClient();
            var product = await client.GetAsync(Urls.GetAllProducts);
            var result = await product.Content.ReadFromJsonAsync<List<Product>>();
            result.ShouldNotBeNull();
            var ormProducts = _productRepository.GetAllProducts();
            result[0].Name.ShouldBe(ormProducts[0].Name);
        }

    }
}

