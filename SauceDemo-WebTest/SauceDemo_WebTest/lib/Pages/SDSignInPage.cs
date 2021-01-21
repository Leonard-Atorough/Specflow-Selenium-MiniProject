using System;
using System.Threading;
using OpenQA.Selenium;


namespace SauceDemo_WebTest
{
    public class SDSignInPage
    {
        private IWebDriver _seleniumDriver;
        private string SignInPageURL = AppConfigReader.SignInPageUrl;
        private IWebElement _usernameField => _seleniumDriver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _errorButton => _seleniumDriver.FindElement(By.ClassName("error-button"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.TagName("h3"));
        private IWebElement _formElement => _seleniumDriver.FindElement(By.TagName("form"));

        public SDSignInPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
            
        }

        public void VisitSignInPage() {
            _seleniumDriver.Navigate().GoToUrl(SignInPageURL);
        }

        public void InputUsername(string username) {
            _usernameField.SendKeys(username);
        }

        public void InputPassword(string password) {
            _passwordField.SendKeys(password);
        }

        public void ClickLogin() {
            _loginButton.Click();
        }

        public void ClearError() {
            _errorButton.Click();
        }

        public string GetError() {
            return _errorMessage.Text;
        }

        public string GetFormText()
        {
            return _formElement.Text;
        }

        public string GetUrl() {
            Thread.Sleep(1000);
            return _seleniumDriver.Url;
        }
    }
}
