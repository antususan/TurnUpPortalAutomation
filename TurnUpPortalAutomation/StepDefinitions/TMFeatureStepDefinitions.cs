using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.AccessControl;
using System.Security.Policy;
using TechTalk.SpecFlow;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        Loginpage loginPageObj = new Loginpage();
        Homepage homePageObj = new Homepage();
        TMpage tmPageObj = new TMpage();

        [Given(@"I logged in to TurnUp portal Successfully")]
        public void GivenILoggedInToTurnUpPortalSuccessfully()

        {
            driver = new ChromeDriver();
            // Login page object initialization and definition 
            
            loginPageObj.LoginActions(driver);
        }

        [Given(@"I navigate to Time and Material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time record")]
        public void WhenICreateANewTimeRecord()
        {
           
            tmPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the record should be created sucessfully")]
        public void ThenTheRecordShouldBeCreatedSucessfully()
        {
            
            string newRecord = tmPageObj.GetCode(driver);
            Assert.That(newRecord == "August16th", "Time record has not been created ");


        }

        [When(@"I update '([^']*)' and '([^']*)'on an existing Time record")]
        public void WhenIUpdateAndOnAnExistingTimeRecord(string p0, string p1)
        {
            
            tmPageObj.EditTimeRecord(driver,p0,p1);

        }

        [Then(@"the record should have an  updated '([^']*)'and '([^']*)'")]
        public void ThenTheRecordShouldHaveAnUpdatedAnd(string p0, string p1)
        {
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedDescription = tmPageObj.GetEditedDescription(driver);
            Assert.That(editedCode == p0, "Edited code has not been updated ");
            Assert.That(editedDescription == p1, "Edited description has not been updated ");

        }







    }
}
