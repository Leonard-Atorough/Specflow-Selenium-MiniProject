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

        [Given(@"I click on the cart icon")]
        public void GivenIClickOnTheCartIcon()
        {
            SD_Website.SD_Productpage.ClickCartIcon();
        }

        [Given(@"I am on the cart page")]
        public void GivenIAmOnTheCartPage()
        {
            SD_Website.SD_Cartpage.GoToCart();
        }


        [When(@"I click on the cart Icon to go to my cart")]
        public void WhenIClickOnTheCartIconToGoToMyCart()
        {
            SD_Website.SD_Productpage.ClickCartIcon();
        }
        
        [When(@"I add multiple (.*) of Items to my cart")]
        public void WhenIAddMultipleOfItemsToMyCart(string items)
        {
            SD_Website.SD_Productpage.AddItemToCart(Int32.Parse(items));
        }

        [When(@"I remove the first item from my cart")]
        public void WhenIRemoveTheFirstItemFromMyCart()
        {
            SD_Website.SD_Cartpage.RemoveClick();
        }

        [When(@"I click the continue shopping button")]
        public void WhenIClickTheContinueShoppingButton()
        {
            SD_Website.SD_Cartpage.ContinueShoppingClick();
        }


        [Then(@"the first item should be in my cart")]
        public void ThenTheFirstItemShouldBeInMyCart()
        {
            Assert.That(SD_Website.SD_Cartpage.GetAnyFirstItem(), Does.Contain("Sauce Labs Backpack"));
        }
        
        [Then(@"the cart counter should display the correct (.*) of items")]
        public void ThenTheCartCounterShouldDisplayTheCorrectOfItems(string expected)
        {
            Assert.That(SD_Website.SD_Cartpage.GetBasketCount(), Is.EqualTo(Int32.Parse(expected)));
        }

        [Then(@"the first item should be removed from my cart")]
        public void ThenTheFirstItemShouldBeRemovedFromMyCart()
        {
            Assert.That(SD_Website.SD_Cartpage.CartPageItemCount(), Is.EqualTo(0));
        }

        [Then(@"I should land on the product page")]
        public void ThenIShouldLandOnTheProductPage()
        {
            Assert.That(SD_Website.SD_Cartpage.GetPageLabel(), Does.Contain("Products"));
        }


        [AfterScenario]
        public void Cleanup()
        {
            SD_Website.CloseBrowser();
        }
    }
}
