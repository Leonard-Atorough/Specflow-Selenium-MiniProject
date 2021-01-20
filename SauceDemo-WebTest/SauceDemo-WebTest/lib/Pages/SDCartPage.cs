using System;
using OpenQA.Selenium;


namespace SauceDemo_WebTest
{
    public class SDCartPage
    {
        private IWebDriver _seleniumDriver;

        private IWebElement _continueShopping => _seleniumDriver.FindElement(By.LinkText("Continue Shopping"));


        public SDCartPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
    }
}
