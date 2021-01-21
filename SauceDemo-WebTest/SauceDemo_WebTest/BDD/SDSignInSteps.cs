using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_WebTest.BDD
{
    [Binding]
    public class SDSignInSteps
    {
        public SDWebsite SDWebsite { get; } = new SDWebsite("Chrome");
        [Given(@"I am on the sign in page")]
        public void GivenIAmOnTheSignInPage()
        {
            SDWebsite.SD_SignInPage.VisitSignInPage();
        }
        
        [Given(@"I have entered the username (.*)")]
        public void GivenIHaveEnteredTheUsername(string username)
        {
            SDWebsite.SD_SignInPage.InputUsername(username);
        }
        
        [Given(@"I have entered the password (.*)")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            SDWebsite.SD_SignInPage.InputPassword(password);
        }
       
        
        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            SDWebsite.SD_SignInPage.ClickLogin();
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            SDWebsite.SD_SignInPage.ClickLogin();
        }
        
        [When(@"I click error message button")]
        public void WhenIClickErrorMessageButton()
        {
            SDWebsite.SD_SignInPage.ClearError();
        }
        
        [Then(@"I should get the error message ""(.*)""")]
        public void ThenIShouldGetTheErrorMessage(string error)
        {
            Assert.That(SDWebsite.SD_SignInPage.GetError(), Does.Contain(error));
        }
        
        [Then(@"I should end up on the inventory page with the url ""(.*)""")]
        public void ThenIShouldEndUpOnTheInventoryPageWithTheUrl(string url)
        {
            Assert.That(SDWebsite.SD_SignInPage.GetUrl(), Is.EqualTo(url));
        }
        
        [Then(@"I should get the error message should disappear")]
        public void ThenIShouldGetTheErrorMessageShouldDisappear()
        {
            Assert.That(SDWebsite.SD_SignInPage.GetFormText(), Does.Not.Contain("Username and password do not match any user in this service"));
        }

        [AfterScenario]
        public void CleanUp()
        {
            SDWebsite.CloseBrowser();
        }
    }
}
