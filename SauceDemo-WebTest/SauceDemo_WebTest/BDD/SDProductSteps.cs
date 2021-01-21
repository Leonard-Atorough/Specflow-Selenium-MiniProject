using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SauceDemo_WebTest
{
    [Binding]
    public class SDProductSteps
    {
        public SDWebsite SD_Website { get; } = new SDWebsite("chrome");

        [Given(@"I am on the product page")]
        public void GivenIAmOnTheProductPage()
        {
            SD_Website.SD_Productpage.VisitProductPage();
        }
        
        [When(@"I select sort by name A-Z")]
        public void WhenISelectSortByNameA_Z()
        {
            SD_Website.SD_Productpage.SortBy("Name (A to Z)");
        }

        [When(@"I select sort by name Z-A")]
        public void WhenISelectSortByNameZ_A()
        {
            SD_Website.SD_Productpage.SortBy("Name (Z to A)");
        }

        [When(@"I select sort by price low-high")]
        public void WhenISelectSortByPriceLow_High()
        {
            SD_Website.SD_Productpage.SortBy("Price (Low to High)");
        }

        [When(@"I select sort by price high-low")]
        public void WhenISelectSortByPriceHigh_Low()
        {
            SD_Website.SD_Productpage.SortBy("Price (High to Low)");
        }

        [Then(@"the products are listed alphabetically")]
        public void ThenTheProductsAreListedAlphabetically()
        {
            Assert.That(SD_Website.SD_Productpage.GetFirstItem(), Is.EqualTo("Sauce Labs Backpack"));
            Assert.That(SD_Website.SD_Productpage.GetSecondItem(), Is.EqualTo("Sauce Labs Bike Light"));
            Assert.That(SD_Website.SD_Productpage.GetThirdItem(), Is.EqualTo("Sauce Labs Bolt T-Shirt"));
            Assert.That(SD_Website.SD_Productpage.GetFourthItem(), Is.EqualTo("Sauce Labs Fleece Jacket"));
            Assert.That(SD_Website.SD_Productpage.GetFifthItem(), Is.EqualTo("Sauce Labs Onesie"));
            Assert.That(SD_Website.SD_Productpage.GetSixthItem(), Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
        }

        [Then(@"the products are listed reverse alphabetically")]
        public void ThenTheProductsAreListedReverseAlphabetically()
        {
            Assert.That(SD_Website.SD_Productpage.GetSixthItem(), Is.EqualTo("Sauce Labs Backpack"));
            Assert.That(SD_Website.SD_Productpage.GetFifthItem(), Is.EqualTo("Sauce Labs Bike Light"));
            Assert.That(SD_Website.SD_Productpage.GetFourthItem(), Is.EqualTo("Sauce Labs Bolt T-Shirt"));
            Assert.That(SD_Website.SD_Productpage.GetThirdItem(), Is.EqualTo("Sauce Labs Fleece Jacket"));
            Assert.That(SD_Website.SD_Productpage.GetSecondItem(), Is.EqualTo("Sauce Labs Onesie"));
            Assert.That(SD_Website.SD_Productpage.GetFirstItem(), Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
        }

        [Then(@"the products are listed cheapest first")]
        public void ThenTheProductsAreListedCheapestFirst()
        {
            Assert.That(SD_Website.SD_Productpage.GetFifthItem(), Is.EqualTo("Sauce Labs Backpack"));
            Assert.That(SD_Website.SD_Productpage.GetSecondItem(), Is.EqualTo("Sauce Labs Bike Light"));
            Assert.That(SD_Website.SD_Productpage.GetThirdItem(), Is.EqualTo("Sauce Labs Bolt T-Shirt"));
            Assert.That(SD_Website.SD_Productpage.GetSixthItem(), Is.EqualTo("Sauce Labs Fleece Jacket"));
            Assert.That(SD_Website.SD_Productpage.GetFirstItem(), Is.EqualTo("Sauce Labs Onesie"));
            Assert.That(SD_Website.SD_Productpage.GetFourthItem(), Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
        }

        [Then(@"the products are listed priciest first")]
        public void ThenTheProductsAreListedPriciestFirst()
        {
            Assert.That(SD_Website.SD_Productpage.GetSecondItem(), Is.EqualTo("Sauce Labs Backpack"));
            Assert.That(SD_Website.SD_Productpage.GetFifthItem(), Is.EqualTo("Sauce Labs Bike Light"));
            Assert.That(SD_Website.SD_Productpage.GetFourthItem(), Is.EqualTo("Sauce Labs Bolt T-Shirt"));
            Assert.That(SD_Website.SD_Productpage.GetFirstItem(), Is.EqualTo("Sauce Labs Fleece Jacket"));
            Assert.That(SD_Website.SD_Productpage.GetSixthItem(), Is.EqualTo("Sauce Labs Onesie"));
            Assert.That(SD_Website.SD_Productpage.GetThirdItem(), Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
        }

        [AfterScenario]
        public void Cleanup()
        {
            SD_Website.CloseBrowser();
        }
    }
}
