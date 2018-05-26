using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Facebook.Common;
using Facebook.Pages;

namespace Facebook
{
    [Binding]
    public class FacebookLoginSteps
    {
        [Given(@"I have navigated to facebook\.com")]
        public void GivenIHaveNavigatedToFacebook_Com()
        {
           CommonFeatures.Initialize();
           LogIn.Navigation();
        }
        
        [Given(@"I have entered my username and password")]
        public void GivenIHaveEnteredMyUsernameAndPassword()
        {
            LogIn.UserNamePassWord();
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            LogIn.ClickLogin();
        }
        
        [Then(@"I can see my homepage")]
        public void ThenICanSeeMyHomepage()
        {
            CommonFeatures.Teardown();
        }
    }
}
