using Autofac;
using OpenQA.Selenium;


namespace WebFrameworkSUT.Infrastructure
{
    public class DriverUtilities : IDriverUtilities
    {
        IWebDriver webDriver;
        private IBrowserDriver _browserDriver;

        public DriverUtilities(IBrowserDriver browserDriver)
        {
            _browserDriver = browserDriver;
            webDriver = GetWebDriver(BrowserTypeEnum.Chrome);
        }
        public void GoToUrl(string url)
        {
            webDriver.Navigate().GoToUrl(new Uri(url));
        }
        public IWebDriver Driver => webDriver;

        private IWebDriver GetWebDriver(BrowserTypeEnum browserType)
        {
            return browserType switch
            {
                BrowserTypeEnum.Chrome => _browserDriver.GetChromeDriver(),
                BrowserTypeEnum.Firefox => _browserDriver.GetFirefoxDriver(),
                BrowserTypeEnum.Edge => _browserDriver.GetEdgeDriver(),
                _ => _browserDriver.GetChromeDriver()
            };
        }
    }

}
