using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.AccessControl;
using TechTalk.SpecFlow;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions:CommonDriver
    {
        [Given(@"I logged in to TurnUp portal Successfully")]
        public void GivenILoggedInToTurnUpPortalSuccessfully()

        {
            driver = new ChromeDriver();
            // Login page object initialization and definition 
            Loginpage loginPageObj = new Loginpage();
            loginPageObj.LoginActions(driver);
        }

        [Given(@"I navigate to Time and Material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            Homepage homePageObj = new Homepage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time record")]
        public void WhenICreateANewTimeRecord()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the record should be created sucessfully")]
        public void ThenTheRecordShouldBeCreatedSucessfully()
        {
            TMpage tmPageObj = new TMpage();
           string newCode = tmPageObj.GetCode(driver);
           Assert.That(newCode == "August16th", "Time record has not been created ");


        }
    }
}
