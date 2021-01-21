using OpenQA.Selenium;

namespace SauceDemo_WebTest
{
    public class SDWebsite
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public SDCartPage SD_Cartpage { get; internal set; }
        public SDSignInPage SD_SignInPage { get; internal set; }
        public SDProductPage SD_Productpage { get; set; }

        public SDWebsite(string driverName, int pageLoadWaitInSecs=10, int ImplicitWaitInSecs=10)
        {
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, ImplicitWaitInSecs).Driver;

            SD_Cartpage = new SDCartPage(SeleniumDriver);
            SD_SignInPage = new SDSignInPage(SeleniumDriver);
            SD_Productpage = new SDProductPage(SeleniumDriver);
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
