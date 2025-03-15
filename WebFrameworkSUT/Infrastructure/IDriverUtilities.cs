using OpenQA.Selenium;

namespace WebFrameworkSUT.Infrastructure
{
    public interface IDriverUtilities
    {
        IWebDriver Driver { get; }
        void GoToUrl(string url);
    }
}