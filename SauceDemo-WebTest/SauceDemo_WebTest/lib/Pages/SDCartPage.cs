using System;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace SauceDemo_WebTest
{
    public class SDCartPage
    {
        private IWebDriver _seleniumDriver;

        private string CartPageUrl = AppConfigReader.CartPageUrl;
        private IWebElement _continueShopping => _seleniumDriver.FindElement(By.XPath("//*[@id=\"cart_contents_container\"]/div/div[2]/a[1]"));
        private IReadOnlyList<IWebElement> _AnyFirstItem => _seleniumDriver.FindElements(By.ClassName("inventory_item_name"));
        private IWebElement _cartCount => _seleniumDriver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a/span"));
        private IWebElement _RemoveFromCartButton => _seleniumDriver.FindElement(By.ClassName("btn_secondary"));
        private IReadOnlyList<IWebElement> _cartItems => _seleniumDriver.FindElements(By.ClassName("cart_item"));
        private IWebElement _pageLabel => _seleniumDriver.FindElement(By.ClassName("product_label"));


        public SDCartPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void GoToCart() => _seleniumDriver.Navigate().GoToUrl(CartPageUrl);
        public string GetAnyFirstItem() => _AnyFirstItem[0].Text;
        public int GetBasketCount() => Int32.Parse(_cartCount.Text);
        public void RemoveClick() => _RemoveFromCartButton.Click();
        public int CartPageItemCount() => _cartItems.Count;
        public string GetPageLabel() => _pageLabel.Text;
        public void ContinueShoppingClick() => _continueShopping.Click();
    }
}
