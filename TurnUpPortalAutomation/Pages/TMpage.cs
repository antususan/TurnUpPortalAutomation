using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Pages
{
    public class TMpage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            // Create a new time record 

            // Navigate to Time and Material Module 

            //click on create button 

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //Select time from dropdown
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecodeDropdown.Click();

            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"TypeCode_listbox\"]/li[2]", 2);
            IWebElement timeTypecode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeTypecode.Click();


            //Enter code
            Wait.Waittobevisible(driver, "Id", "Code", 2);
            IWebElement codeTexbox = driver.FindElement(By.Id("Code"));
            codeTexbox.SendKeys("August16th");


            //Enter Description 
            Wait.Waittobevisible(driver, "Id", "Description", 2);
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("August16th");


            // Enter Price 
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 2);
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("12");


            //Click on save button 
            Wait.Waittobeclickable(driver, "Id", "SaveButton", 2);
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

         
            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 2);

            //check if new time record has been created suceesfully 
            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",10);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 10);

            IWebElement newRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

      
        }
        public string GetCode(IWebDriver driver)
        {
            IWebElement newRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newRecord.Text;
        }
        public void EditTimeRecord(IWebDriver driver)
        {
            IWebElement goToLastPageButtonForEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            goToLastPageButtonForEdit.Click();

            //click on Edit button 

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //select material from dropdown 
            IWebElement typecodeDropdownForEdit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecodeDropdownForEdit.Click();

            
            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"TypeCode_listbox\"]/li[1]", 2);
            IWebElement materialtypecode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            materialtypecode.Click();


            //Edit  code 
            Wait.Waittobevisible(driver, "Id", "Code", 2);
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("August19th");


            //Edit Description 
            Wait.Waittobevisible(driver, "Id", "Description", 2);
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("August19th2023");


            //Edit price
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 2);
            IWebElement overlapEditPriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            overlapEditPriceTextbox.Click();

            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            editPriceTextbox.Clear();
            overlapEditPriceTextbox.Click();
            editPriceTextbox.SendKeys("3");


            //Click on the save button 
            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"SaveButton\"]", 2);
            IWebElement editClickSaveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            editClickSaveButton.Click();

            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 2);
            IWebElement goToLastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            goToLastpage.Click();

            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 2);

            //Verify if the edited record has been changed sucessfully 

            IWebElement editedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(editedRecord.Text == "August19th", "Record has not been Edited");
            //if (editedRecord.Text == "August19th")
            //{
            //    Console.WriteLine("Record has been sucessfully Edited ");
            //}
            //else
            //{
            //    Console.WriteLine("Record has not been Edited  ");
            //}


        }

        public void DeleteTimeRecord(IWebDriver driver)
        {
            //delete button 

            IWebElement goToLastpageButtonForDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            goToLastpageButtonForDelete.Click();

            //click delete button 

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            Thread.Sleep(2000);

            //navigate to popup page & Click ok Button
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(2000);

            //check the deleted record is disappered 

            IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(deletedRecord.Text  != "August19th", "Record has not been Deleted");
            //if (deletedRecord.Text != "August19th")
            //{
            //    Console.WriteLine("Record has been deleted Successfully");
            //}

            //else
            //{
            //    Console.WriteLine("Record has not been Deleted ");
            //}
        }

    }
}
