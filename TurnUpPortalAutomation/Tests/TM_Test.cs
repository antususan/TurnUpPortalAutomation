using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Tests
{
    [Parallelizable]
    [TestFixture]
    public class TM_Test:CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {
            //open the browser 

            driver = new ChromeDriver();

            //wait Implicit wait 
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Login page object initialization and definition 
            Loginpage loginPageObj = new Loginpage();
            loginPageObj.LoginActions(driver);

            // Home page object initialization and definition
            Homepage homePageObj = new Homepage();
            homePageObj.GoToTMPage(driver);

        }
        [Test,Order (1),Description("This Test create a new Time record with Valid Data")]
        public void createTime_Test()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.CreateTimeRecord(driver);
        }
        [Test,Order(2), Description("This Test Edit an existing Time Record  with Valid Data")]
        public void EditTime_Test()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.EditTimeRecord(driver,"Whatever");
        }
        [Test,Order(3), Description("This Test Delete an existing Time Record ")]
        public void DeleteTime_Test()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
