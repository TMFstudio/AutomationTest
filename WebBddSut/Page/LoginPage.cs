using OpenQA.Selenium;
using WebFrameworkSUT.Helper;
using WebFrameworkSUT.Infrastructure;

namespace WebBddSut.Page
{
    public class LoginPage : ILoginPage
    {
        private readonly IDriverUtilities _driverUtilities;
        public LoginPage(IDriverUtilities driverUtilities)
        {
            _driverUtilities = driverUtilities;
        }
        IWebElement TxtUsername => _driverUtilities.Driver.FindElement(By.Id("user-name"));
        IWebElement TxtPassword => _driverUtilities.Driver.FindElement(By.Id("password"));
        IWebElement Loginbtn => _driverUtilities.Driver.FindElement(By.Id("login-button"));
        IWebElement BurgerMenubtn => _driverUtilities.Driver.FindElement(By.Id("react-burger-menu-btn"));
        IWebElement Logoutbtn => _driverUtilities.Driver.FindElement(By.Id("logout_sidebar_link"));
        IWebElement TxtProduct => _driverUtilities.Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/div"));
        IWebElement TxtMassage => _driverUtilities.Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/div[3]"));
        IWebElement ErrorBox => _driverUtilities.Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/div[3]"));
        IWebElement ProductFilter => _driverUtilities.Driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div/span/select"));

        public void SelectFilterByValue(string value)
        {
            ProductFilter.SelectByValue(value);
        }
        public bool ErrorBoxDisplayed()
        {
            if (ErrorBox.Displayed)
                return true;
            return false;
        }
        public string TxtMassageText() => TxtMassage.Text;
        public string TxtProductText() => TxtProduct.Text;


        public void Login(string username, string password)
        {
            TxtUsername.SendKeys(username);
            TxtUsername.SendKeys(password);
            Loginbtn.Click();
        }
        public void Logout()
        {
            if (_driverUtilities.Driver.IsCookieExist("session-username"))
            {
                BurgerMenubtn.Click();
                Thread.Sleep(4000);
                Logoutbtn.Click();
            }
        }
    }
}
