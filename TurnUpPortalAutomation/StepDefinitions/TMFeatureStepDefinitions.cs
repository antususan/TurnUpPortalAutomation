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
           string newRecord = tmPageObj.GetCode(driver);
           Assert.That(newRecord == "August16th", "Time record has not been created ");


        }

        [When(@"I update '([^']*)' on an existing Time record")]
        public void WhenIUpdateOnAnExistingTimeRecord(string P0)
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.EditTimeRecord(driver, P0);
        }

        [Then(@"the record should have an  updated '([^']*)'")]
        public void ThenTheRecordShouldHaveAnUpdated(string P0)
        {
            TMpage tmPageObj = new TMpage();
            string editedCode = tmPageObj.GetEditedCode(driver);
            Assert.That(editedCode == P0, "The Record has not been updated ");

        }

    }
}
