namespace BddWebSUT.Page
{
    public interface ILoginPage
    {
        public void Login(string username, string password);
        public void Logout();
        public void SelectFilterByValue(string value);
        public bool ErrorBoxDisplayed();
        public string TxtMassageText();
        public string TxtProductText();
    }
}