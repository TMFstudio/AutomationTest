using BddWebSUT.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using WebFrameworkSUT.Helper;
using WebFrameworkSUT.Infrastructure;

namespace BddWebSUT.UITest
{
    public class Login : WebDriver, IDisposable
    {
        private IDriverUtilities _driverUtilities;
        private IBrowserDriver _browserDriver;
        private ILoginPage _loginPage;
        IWebDriver webDriver;
        [OneTimeSetUp]
        public void Setup()
        {
            _driverUtilities = GetService<IDriverUtilities>();
            webDriver = _driverUtilities.Driver;
            _loginPage = GetService<ILoginPage>();
            webDriver.Navigate().GoToUrl(Urls.Saucedemo);
        }
        [SetUp]
        public void Refresh()
        {
            webDriver.Navigate().Refresh();
        }

        [Test, Order(1)]
        public void Successfully_Login_Test()
        {
            _loginPage.Login("standard_user", "secret_sauce");
            var cookie = webDriver.IsCookieExist("session-username");

            Assert.IsTrue(cookie);
        }

        [TestCase("za", "$15.99"), Order(0)]
        public void Select_Filter_Test(string value, string price)
        {
            _loginPage.SelectFilterByValue(value);
            Thread.Sleep(1000);
            var productPrice = _loginPage.TxtProductText();
            Assert.AreEqual(productPrice, price);

        }

        [Test, Order(0)]
        public void Faild_Login_Test()
        {
            // login failed
            _loginPage.Login("far", "123");

            var message = _loginPage.TxtMassageText();
            var errorBox = _loginPage.ErrorBoxDisplayed();

            Assert.That(message, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
            Assert.IsTrue(errorBox);

        }

        [Test, Order(3)]
        public void Successfully_Logout_Test()
        {
            _loginPage.Logout();
            Assert.IsFalse(webDriver.IsCookieExist("session-username"));
        }
        [OneTimeTearDown]
        public void Dispose()
        {
            webDriver.Quit();
        }
    }
}