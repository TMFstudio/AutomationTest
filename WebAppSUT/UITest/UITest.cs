using BddWebSUT.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using WebFrameworkSUT.Helper;
using WebFrameworkSUT.Infrastructure;


namespace BddWebSUT.UITest
{
    [TestFixture]
    public class UITest : WebDriver, IDisposable
    {
        private IHomePage _homePage;
        private IDriverUtilities _driverUtilities;
        private ICreateProductPage _createProductPage;
        IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            _driverUtilities = GetService<IDriverUtilities>();
            webDriver = _driverUtilities.Driver;
            _homePage = GetService<IHomePage>();
            _createProductPage = GetService<ICreateProductPage>();
            webDriver.Navigate().GoToUrl(Urls.BaseUrl);
        }
        //old vertion of selenium with out POM
        //[Test]
        //public void Create()
        //{
        //    webDriver.FindElement(By.LinkText("Products")).Click();
        //    webDriver.FindElement(By.LinkText("Create New")).Click();
        //    _homePage.ClickProduct();
        //    _homePage.ClickCreateProduct();

        //    webDriver.FindElement(By.Id("Id")).SendKeys("0");
        //    webDriver.FindElement(By.Id("Name")).SendKeys("IPhone 33");
        //    webDriver.FindElement(By.Id("Price")).SendKeys("200");
        //    webDriver.FindElement(By.Id("Discription")).SendKeys("IPhone 33 dadad");
        //    webDriver.FindElement(By.Id("ProductType")).SendKeys("1");
        //    webDriver.FindElement(By.XPath("/html/body/div/main/div[1]/div/div[6]/input")).Click();
        //    _createProductPage.NewPorduct(new Product
        //    {
        //        Id = 0,
        //        Name = "POM",
        //        Description = "IPhone 33 dadad",
        //        Price = 100,
        //        ProductType = 1
        //    });
        //}
        [OneTimeTearDown]
        public void Dispose()
        {
            webDriver.Quit();
        }
    }
}