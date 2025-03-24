using ProductDataApi.Repository;
using ProductDataApi.Data;
using Shouldly;
using BddWebSUT.IntegrationTest;
using NUnit.Framework;

namespace BddWebSUT.ORMTest
{
    [TestFixture]
    public class OrmTests : StartUp
    {
        private IProductRepository _productRepository;

        [Test]
        public async Task GetAllProductShouldNotBeNull()
        {
            var product = _productRepository.GetAllProducts();

            Assert.That(product, !Is.Null);
        }
        [Test]
        public async Task TestCrud()
        {
            var newProduct = new Product()
            {
                Datetime = DateTime.Now,
                Description = "bla bla bla 2",
                Name = "Nokia1100",
                Price = 1m,
                ProductType = ProductType.Nokia
            };
            var allProduct = _productRepository.GetAllProducts();

            allProduct.Count.ShouldBe(4);

            _productRepository.CreateProduct(newProduct);

            allProduct = _productRepository.GetAllProducts();

            allProduct.Count.ShouldBe(5);

            var testProduct = allProduct.FirstOrDefault(x => x.Name == newProduct.Name);
            var newProductName = "nokia007";
            testProduct.Name = newProductName;

            _productRepository.UpdateProduct(testProduct);

            allProduct = _productRepository.GetAllProducts();

            testProduct = allProduct.FirstOrDefault(x => x.Name == newProductName);

            _productRepository.DeleteProduct(testProduct.Id);

            allProduct = _productRepository.GetAllProducts();

            allProduct.Count.ShouldBe(4);

        }
    }
}