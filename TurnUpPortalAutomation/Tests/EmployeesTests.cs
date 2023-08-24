using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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
    public class EmployeesTests:CommonDriver
    {
        [SetUp]
        public void EmployeesSetup()
        {
            //open the browser 

            driver = new ChromeDriver();
            // Login page object initialization and definition 
            Loginpage loginPageObj = new Loginpage();
            loginPageObj.LoginActions(driver);

            //homepage object initialization and definition 
            Homepage homePageObj = new Homepage();
            homePageObj.GoToEmployeesPage(driver);

        }
        [Test]
        public void CreateEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.CreateEmployee(driver);

        }
        [Test]
        public void EditEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.EditEmployee(driver);

        }
        [Test]
        public void DeleteEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.DeleteEmployee(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
