using OpenQA.Selenium;
using System.Collections.Generic;

namespace SauceDemo_WebTest
{
    public class SDProductPage
    {
        private IWebDriver _seleniumDriver;
        private string ProductPageURL = AppConfigReader.ProductPageUrl;
        private IWebElement _sortContainer => _seleniumDriver.FindElement(By.ClassName("product_sort_container"));
        private IWebElement _firstItem => _seleniumDriver.FindElement(By.XPath(@"//*[@id='inventory_container']/div/div[1]/div[2]/a"));

        private IWebElement _cartIcon => _seleniumDriver.FindElement(By.ClassName("shopping_cart_link"));

        private IReadOnlyList<IWebElement> _AnyFirstItem => _seleniumDriver.FindElements(By.ClassName("inventory_item_name"));
        private IReadOnlyList<IWebElement> _AddToCartButton => _seleniumDriver.FindElements(By.ClassName("btn_primary"));


        public SDProductPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitProductPage()
        {
            _seleniumDriver.Navigate().GoToUrl(ProductPageURL);
        }

        public void SortByNameAZ()
        {
            _sortContainer.SendKeys("Name (A to Z)");
        }

        public string GetFirstItem()
        {
            return _firstItem.Text;
        }

        public string GetAnyFirstItem() => _AnyFirstItem[0].Text;

        public void AddItemToCart() => _AddToCartButton[0].Click();
 
        public void AddItemToCart(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _AddToCartButton[i].Click();
            }
        }
        public void ClickCartIcon() => _cartIcon.Click();
    }
}