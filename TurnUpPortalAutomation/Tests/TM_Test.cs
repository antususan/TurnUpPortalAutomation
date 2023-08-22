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
            Loginpage loginpageObj = new Loginpage();
            loginpageObj.LoginActions(driver);

            // Home page object initialization and definition
            Homepage homePageobj = new Homepage();
            homePageobj.GoToTMPage(driver);

        }
        [Test]
        public void createTime_Test()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.createTimeRecord(driver);
        }
        [Test]
        public void EditTime_Test()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.EditTimeRecord(driver);
        }
        [Test]
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
