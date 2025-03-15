using OpenQA.Selenium;

namespace WebFrameworkSUT.Infrastructure
{
    public interface IBrowserDriver
    {
        IWebDriver GetChromeDriver();
        IWebDriver GetEdgeDriver();
        IWebDriver GetFirefoxDriver();
    }
}