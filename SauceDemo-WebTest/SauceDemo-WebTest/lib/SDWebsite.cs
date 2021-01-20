using OpenQA.Selenium;

namespace SauceDemo_WebTest
{
    public class SDWebsite
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public SDCartPage SD_Cartpage { get; internal set; }
        

        public SDWebsite(string driverName, int pageLoadWaitInSecs=10, int ImplicitWaitInSecs=10)
        {
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, ImplicitWaitInSecs).Driver;

            SD_Cartpage = new SDCartPage(SeleniumDriver);

        }

    public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }

        public void CloseBrowser()
        {
            SeleniumDriver.Quit();
            SeleniumDriver.Dispose();
        }
    }
}
