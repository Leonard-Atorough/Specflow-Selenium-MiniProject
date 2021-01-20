using System;
using TechTalk.SpecFlow;

namespace SauceDemo_WebTest.BDD
{
    [Binding]
    public class SDProductSteps
    {
        [Given(@"I am on the product page")]
        public void GivenIAmOnTheProductPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select sort by name A-Z")]
        public void WhenISelectSortByNameA_Z()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the products are listed alphabetically")]
        public void ThenTheProductsAreListedAlphabetically()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
