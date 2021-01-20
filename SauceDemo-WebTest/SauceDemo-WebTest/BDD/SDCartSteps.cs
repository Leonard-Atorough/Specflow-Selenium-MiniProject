using System;
using TechTalk.SpecFlow;

namespace SauceDemo_WebTest.BDD
{
    [Binding]
    public class SDCartSteps
    {
        SDWebsite SD_Website = new SDWebsite("chome");

        [Given(@"I am on the products page")]
        public void GivenIAmOnTheProductsPage()
        {
            SD_Website.SD_Productpage.VisitProductPage();
        }
        
        [Given(@"I add the first item to my cart")]
        public void GivenIAddTheFirstItemToMyCart()
        {
            SD_Website.SD_Productpage.
        }
        
        [When(@"I click on the cart Icon to go to my cart")]
        public void WhenIClickOnTheCartIconToGoToMyCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add multiple (.*) of Items to my cart")]
        public void WhenIAddMultipleOfItemsToMyCart(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the first item should be in my cart")]
        public void ThenTheFirstItemShouldBeInMyCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the cart counter should display the correct (.*) of items")]
        public void ThenTheCartCounterShouldDisplayTheCorrectOfItems(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
