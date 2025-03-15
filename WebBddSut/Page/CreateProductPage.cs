using OpenQA.Selenium;
using System.Xml.Linq;
using WebBddSut.Model;
using WebFrameworkSUT.Helper;
using WebFrameworkSUT.Infrastructure;

namespace WebBddSut.Page
{
    public class CreateProductPage : ICreateProductPage
    {
        private readonly IDriverUtilities _driverUtilities;
        public CreateProductPage(IDriverUtilities driverUtilities)
        {
            _driverUtilities = driverUtilities;
        }
        IWebElement TxtId => _driverUtilities.Driver.FindElement(By.Id("Id"));
        IWebElement TxtName => _driverUtilities.Driver.FindElement(By.Id("Name"));
        IWebElement TxtPrice => _driverUtilities.Driver.FindElement(By.Id("Price"));
        IWebElement TxtDescription => _driverUtilities.Driver.FindElement(By.Id("Description"));
        IWebElement TxtProductType => _driverUtilities.Driver.FindElement(By.Id("ProductType"));
        IWebElement CreatBtn => _driverUtilities.Driver.FindElement(By.Id("Create"));
        public Product GetProductDetails(string productName)
        {
            //click to product detail
            _driverUtilities.Driver.FindElement(By.Id(productName)).Click();
            return new Product
            {
                Name = TxtName.Text,
                ProductType = int.Parse(TxtProductType.Text),
                Price = decimal.Parse(TxtPrice.Text),
                Description = TxtDescription.Text,
            };
        }
        public void NewPorduct(Product product)
        {
            TxtId.SendKeys(product.Id.ToString());
            TxtName.SendKeys(product.Name);
            TxtDescription.SendKeys(product.Description);
            TxtPrice.SendKeys(product.Price.ToString());
            TxtProductType.SendKeys(product.ProductType.ToString());
            CreatBtn.Click();
        }  


    }
}
