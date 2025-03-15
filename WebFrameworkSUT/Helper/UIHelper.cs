using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebFrameworkSUT.Helper
{
    public static class UIHelper
    {
        public static bool IsCookieExist(this IWebDriver webDriver, string cookieName)
        {
            return webDriver.Manage().Cookies.GetCookieNamed(cookieName) != null;
        }
        public static void SelectByValue(this IWebElement webElement, string value)
        {
            var element = new SelectElement(webElement);
            element.SelectByValue(value);
        }
        public static void GetScreenshot(this IWebDriver webDriver, string fileName)
        {
            Screenshot ss = ((ITakesScreenshot)webDriver).GetScreenshot();
            ss.SaveAsFile(@$"C:\Users\farbod\source\repos\WebAppUnderTest\WebAppSUT\Screenshot\{fileName}.png");
        }
    }
}
