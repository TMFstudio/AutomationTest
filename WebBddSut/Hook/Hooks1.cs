using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebFrameworkSUT.Helper;
using WebFrameworkSUT.Infrastructure;

namespace WebBddSut.Hook
{
    [Binding]
    public sealed class Hooks1: IDisposable
    {
        IWebDriver driver;
        private IDriverUtilities _driverUtilities;
        public Hooks1(IDriverUtilities _driverUtilities)
        {
            driver = _driverUtilities.Driver;
        }
        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            driver.Navigate().GoToUrl(Urls.BaseUrl);
        } 

        [AfterScenario]
        public void Dispose()
        {
            driver.Quit();
        }
    }
}