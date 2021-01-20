using OpenQA.Selenium;

namespace SauceDemo_WebTest
{
    public class SDProduct
    {
        private IWebDriver _seleniumDriver;
        private string ProductPageURL = AppConfigReader.ProductPageUrl;
        private IWebElement _sortContainer => _seleniumDriver.FindElement(By.ClassName("product_sort_container"));

        public SDProduct(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitProductPage()
        {
            _seleniumDriver.Navigate().GoToUrl(ProductPageURL);
        }
    }
}