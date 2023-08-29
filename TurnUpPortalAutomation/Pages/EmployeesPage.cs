using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Pages
{
    public class EmployeesPage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //create new Employee
            //Click on create button
            Wait.Waittobeclickable(driver, "Xpath","//*[@id=\"container\"]/p/a",5);
            IWebElement createEmployee = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createEmployee.Click();



            //Enter Name
            Wait.Waittobevisible(driver,"Id","Name",5);
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Ekkujames");


            //Enter Username
            Wait.Waittobevisible(driver,"Id","Username",5);
            IWebElement usernameTextBox = driver.FindElement(By.Id("Username"));
            usernameTextBox.SendKeys("james");


            //Enter Contact
            //Enter contacts details in Edit contact 
            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"EditContactButton\"]", 5);
            IWebElement editContactButton = driver.FindElement(By.XPath("//*[@id=\"EditContactButton\"]"));
            editContactButton.Click();
            

            driver.SwitchTo().Frame(0);

            //Enter FirstName
            Wait.Waittobevisible(driver, "Id", "FirstName", 5);
            IWebElement firstNameTextBox = driver.FindElement(By.Id("FirstName"));
            firstNameTextBox.SendKeys("Ekku");


            //Enter Last Name 
            Wait.Waittobevisible(driver, "Id", "LastName", 5);
            IWebElement lastNameTextBox = driver.FindElement(By.Id("LastName"));
            lastNameTextBox.SendKeys("James");


            //Enter PreferedName
            Wait.Waittobevisible(driver, "Id", "PreferedName", 5);
            IWebElement preferedNameTextBox = driver.FindElement(By.Id("PreferedName"));
            preferedNameTextBox.SendKeys("Ekku");



            //Enter Phone
            Wait.Waittobevisible(driver, "Id", "Phone", 5);
            IWebElement phoneTextBox = driver.FindElement(By.Id("Phone"));
            phoneTextBox.SendKeys("01234567");


            //Enter Mobile 
            Wait.Waittobevisible(driver, "Id", "Mobile", 5);
            IWebElement mobileTextBox = driver.FindElement(By.Id("Mobile"));
            mobileTextBox.SendKeys("0123456789");


            //Enter Email
            Wait.Waittobevisible(driver, "Id", "email", 5);
            IWebElement emailTextBox = driver.FindElement(By.Id("email"));
            emailTextBox.SendKeys("jamesekkuname@gmail.com");


            //Enter Fax
            Wait.Waittobevisible(driver, "Id", "Fax", 5);
            IWebElement faxTextBox = driver.FindElement(By.Id("Fax"));
            faxTextBox.SendKeys("222");


            //Enter Address 

            //try
            //{


            //    //Identify Address textbox and enter address 
            //    IWebElement addressTextBox = driver.FindElement(By.Id("autocomplete"));
            //    addressTextBox.SendKeys("abcd address");
            //    Thread.Sleep(2000);
            //}
            //catch (Exception ex)
            //{
            //    Assert.Fail("Address: should NOT be used ", ex.Message);

            //}

            //Enter Street
            Wait.Waittobevisible(driver, "Id", "Street", 5);
            IWebElement streetTextBox = driver.FindElement(By.Id("Street"));
            streetTextBox.SendKeys("12");


            //Enter City
            Wait.Waittobevisible(driver, "Id", "City", 5);
            IWebElement cityTextBox = driver.FindElement(By.Id("City"));
            cityTextBox.SendKeys("Cambridge");


            //Enter Postcode
            Wait.Waittobevisible(driver, "Id", "Postcode", 5);
            IWebElement postcodeTextBox = driver.FindElement(By.Id("Postcode"));
            postcodeTextBox.SendKeys("3432");


            //Enter Country
            Wait.Waittobevisible(driver, "Id", "Country", 5);
            IWebElement countryTextBox = driver.FindElement(By.Id("Country"));
            countryTextBox.SendKeys("New Zealand");



            //Click Save Contact Button 
            Wait.Waittobeclickable(driver, "Id", "submitButton", 5);
            IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            saveContactButton.Click();

            driver.SwitchTo().DefaultContent();

            //Enter Password
            Wait.Waittobevisible(driver, "Id", "Password", 5);
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("J@me5ekku");


            //Enter Retype Password 
            Wait.Waittobevisible(driver, "Id", "RetypePassword", 5);
            IWebElement reTypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            reTypePasswordTextBox.SendKeys("J@me5ekku");


            //Check IsAdmin
            //IWebElement isAdminCheckBox = driver.FindElement(By.Id("IsAdmin"));
            //isAdminCheckBox.Click();
            //Thread.Sleep(2000);

            //Enter Vehicle 
            //IWebElement vehicleTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            //vehicleTextBox.SendKeys("1001");
            //Thread.Sleep(2000);

            //Enter Groups 
            //IWebElement groupsDropdown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            //groupsDropdown.Click();
            //Thread.Sleep(2000);

            //IWebElement selectGroup = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[80]"));
            //selectGroup.Click();
            //Thread.Sleep(2000);

            //Click Save button 
            Wait.Waittobeclickable(driver, "Id", "SaveButton", 5);
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(7000);

            // Back to list page to check the new employee details has been added 
            //Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"container\"]/div/a", 10);
            IWebElement backToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToLastPageButton.Click();


            // Goto last page to check the new employee details has been added 
            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"usersGrid\"]/div[4]/a[4]", 10);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            goToLastPageButton.Click();

            Thread.Sleep(7000);
         
            //Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 5);
            IWebElement newEmployeeRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newEmployeeRecord.Text == "Ekkujames", "New Employee has not been created");

            Thread.Sleep(7000);
        }

        public void EditEmployee(IWebDriver driver)
        {

        }

        public void DeleteEmployee(IWebDriver driver)
        {

        }
    }
}



