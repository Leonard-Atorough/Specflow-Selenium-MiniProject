using System;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace SauceDemo_WebTest
{
    public class SDCartPage
    {
        private IWebDriver _seleniumDriver;

        private string CartPageUrl = AppConfigReader.CartPageUrl;
        private IWebElement _continueShopping => _seleniumDriver.FindElement(By.LinkText("Continue Shopping"));
        private IReadOnlyList<IWebElement> _AnyFirstItem => _seleniumDriver.FindElements(By.ClassName("inventory_item_name"));
        private IWebElement _cartCount => _seleniumDriver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a/span"));


        public SDCartPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public string GetAnyFirstItem() => _AnyFirstItem[0].Text;

        public int GetBasketCount() => Int32.Parse(_cartCount.Text);
    }
}
