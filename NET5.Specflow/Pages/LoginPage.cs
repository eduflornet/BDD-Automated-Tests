using OpenQA.Selenium;

namespace NET5.Specflow.Pages
{
    class LoginPage
    {
        public IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtxUserName => WebDriver.FindElement(By.LinkText("UserName"));
        public IWebElement txtPassword => WebDriver.FindElement(By.LinkText("Password"));
        public IWebElement btnLogin => WebDriver.FindElement(By.LinkText(".btn-default"));
        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => lnkLogin.Click();

        public void Login(string userName, string password)
        {
            txtxUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => btnLogin.Submit();
        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;


    }

    
}
