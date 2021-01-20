using System;
using OpenQA.Selenium;


namespace SauceDemo_WebTest
{
    public class SDSignInPage
    {
        private IWebDriver _seleniumDriver;

        private IWebElement _usernameField => _seleniumDriver.FindElement(By.Id(""));


        public SDCartPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
    }
}
