using DataDrivenWithExample.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithExample.StepDefinitions
{
    [Binding]
    public class DataDrivenWithExampleStepDefinitions

    {

        DataDrivenWithExamplePage dataDrivenWithExamplePage;
        public DataDrivenWithExampleStepDefinitions() 
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();
        }
        
        
        
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            dataDrivenWithExamplePage.NavigateToWebsite();
        }

        [Given(@"I click on Sign Up")]
        public void GivenIClickOnSignUp()
        {
            dataDrivenWithExamplePage.ClickOnSignUp();
        }

        [Given(@"I enter Username text ""([^""]*)""")]
        public void GivenIEnterUsernameText(string username)
        {
            dataDrivenWithExamplePage.EnterUsername(username);
        }

        [Given(@"I enter Email text ""([^""]*)""")]
        public void GivenIEnterEmailText(string email)
        {
            dataDrivenWithExamplePage.EnterEmail(email);
        }

        [Given(@"I enter Password text ""([^""]*)""")]
        public void GivenIEnterPasswordText(string password)
        {
            dataDrivenWithExamplePage.EnterPassword(password);
        }

        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            dataDrivenWithExamplePage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            dataDrivenWithExamplePage.IsNewArticleDisplaced();
        }
    }
}
