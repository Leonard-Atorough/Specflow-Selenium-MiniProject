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
            SD_Website.SD_Productpage.SortByNameAZ();
        }
        
        [Then(@"the products are listed alphabetically")]
        public void ThenTheProductsAreListedAlphabetically()
        {
            Assert.That(SD_Website.SD_Productpage.GetFirstItem(), Is.EqualTo("Sauce Labs Backpack"));
        }
    }
}
