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
        public void createTimeRecord(IWebDriver driver)
        {
            // Create a new time record 

            // Navigate to Time and Material Module 

            //click on create button 

            IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewbutton.Click();

            //Select time from dropdown
            IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecodedropdown.Click();
            Thread.Sleep(1000);

            IWebElement timetypecode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timetypecode.Click();
            Thread.Sleep(1000);

            //Enter code
            IWebElement codetexbox = driver.FindElement(By.Id("Code"));
            codetexbox.SendKeys("August16th");
            Thread.Sleep(1000);

            //Enter Description 
            IWebElement descriptiontexbox = driver.FindElement(By.Id("Description"));
            descriptiontexbox.SendKeys("August16th");
            Thread.Sleep(1000);

            // Enter Price 
            IWebElement pricetextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricetextbox.SendKeys("12");
            Thread.Sleep(1000);

            //Click on save button 
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();

            Thread.Sleep(1000);

            //check if new time record has been created suceesfully 
            Wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",2);
            IWebElement gotolastbutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastbutton.Click();

            Thread.Sleep(1000);

            IWebElement newrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(newrecord.Text == "August16th", "Time record has not been created ");

            //if (newrecord.Text == "August16th")
            //{
            //    Assert .Pass("New Time record has been created sucessfully ");
            //}
            //else
            //{
            //    Assert.Fail("Time record has not been created ");

            //}
        }
        public void EditTimeRecord(IWebDriver driver)
        {
            IWebElement gotolastpageforedit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            gotolastpageforedit.Click();

            //click on Edit button 

            IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Editbutton.Click();

            //select material from dropdown 
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            dropdown.Click();

            Thread.Sleep(1000);

            IWebElement materialfromtypecode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            materialfromtypecode.Click();
            Thread.Sleep(1000);

            //Edit  code 
            IWebElement editcodetext = driver.FindElement(By.Id("Code"));
            editcodetext.Clear();
            editcodetext.SendKeys("August19th");
            Thread.Sleep(1000);

            //Edit Description 
            IWebElement editdescriptiontext = driver.FindElement(By.Id("Description"));
            editdescriptiontext.Clear();
            editdescriptiontext.SendKeys("August19th2023");
            Thread.Sleep(1000);

            //Edit price
            IWebElement overlapeditpricetext = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            overlapeditpricetext.Click();

            IWebElement editpricetext = driver.FindElement(By.Id("Price"));
            editpricetext.Clear();
            overlapeditpricetext.Click();
            editpricetext.SendKeys("3");

            Thread.Sleep(1000);
            //Click on the save button 
            IWebElement clickeditsavebutton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            clickeditsavebutton.Click();

            Thread.Sleep(1000);
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            gotolastpage.Click();

            Thread.Sleep(1000);

            IWebElement editedrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editedrecord.Text == "August19th")
            {
                Console.WriteLine("Record has been sucessfully Edited ");
            }
            else
            {
                Console.WriteLine("Record has not been Edited  ");
            }


        }

        public void DeleteTimeRecord(IWebDriver driver)
        {
            //delete button 

            IWebElement gotolastpagefordelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            gotolastpagefordelete.Click();

            //click delete button 

            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deletebutton.Click();

            Thread.Sleep(2000);

            //navigate to popup page & Click ok Button
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(2000);

            //check the deleted record is disappered 

            IWebElement deletedrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (deletedrecord.Text != "August19th")
            {
                Console.WriteLine("Record has been deleted Successfully");
            }

            else
            {
                Console.WriteLine("Record has not been Deleted ");
            }
        }

    }
}
