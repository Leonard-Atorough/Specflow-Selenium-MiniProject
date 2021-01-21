using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SauceDemo_WebTest.BDD
{
    [Binding]
    public class SDCartSteps
    {
        SDWebsite SD_Website = new SDWebsite("chrome");

        [Given(@"I am on the products page")]
        public void GivenIAmOnTheProductsPage()
        {
            SD_Website.SD_Productpage.VisitProductPage();
        }
        
        [Given(@"I add the first item to my cart")]
        public void GivenIAddTheFirstItemToMyCart()
        {
            SD_Website.SD_Productpage.AddItemToCart();
        }
        
        [When(@"I click on the cart Icon to go to my cart")]
        public void WhenIClickOnTheCartIconToGoToMyCart()
        {
            SD_Website.SD_Productpage.ClickCartIcon();
        }
        
        [When(@"I add multiple (.*) of Items to my cart")]
        public void WhenIAddMultipleOfItemsToMyCart(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the first item should be in my cart")]
        public void ThenTheFirstItemShouldBeInMyCart()
        {
            Assert.That(SD_Website.SD_Cartpage.GetAnyFirstItem, Does.Contain("Sauce Labs Backpack"));
        }
        
        [Then(@"the cart counter should display the correct (.*) of items")]
        public void ThenTheCartCounterShouldDisplayTheCorrectOfItems(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [AfterScenario]
        public void Cleanup()
        {
            SD_Website.CloseBrowser();
        }
    }
}
