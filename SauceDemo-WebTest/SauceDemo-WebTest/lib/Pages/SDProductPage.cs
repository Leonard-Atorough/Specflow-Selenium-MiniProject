using OpenQA.Selenium;

namespace SauceDemo_WebTest
{
    public class SDProductPage
    {
        private IWebDriver _seleniumDriver;
        private string ProductPageURL = AppConfigReader.ProductPageUrl;
        private IWebElement _sortContainer => _seleniumDriver.FindElement(By.ClassName("product_sort_container"));
        private IWebElement _firstItem => _seleniumDriver.FindElement(By.XPath(@""));

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
    }
}