using OpenQA.Selenium;
using WebFrameworkSUT.Infrastructure;

namespace WebBddSut.Page
{
    public class HomePage : IHomePage
    {
        private readonly IDriverUtilities _driverUtilities;
        public HomePage(IDriverUtilities driverUtilities)
        {
            _driverUtilities = driverUtilities;
        }
        IWebElement lnkProduct => _driverUtilities.Driver.FindElement(By.LinkText("Products"));
        IWebElement lnkCreateProduct => _driverUtilities.Driver.FindElement(By.LinkText("Create New"));

        public void ClickProduct()
        {
            lnkProduct.Click();
        }
        public void ClickCreateProduct()
        {
            lnkCreateProduct.Click();
        }
    }
}
