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
    public class Loginpage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            // Launch turnup portal and navigation to login
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

            try
            {


                //Identify username textbox and enter Valid username 
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup Portal page didnot launch", ex.Message);
                    
            }
            //Identify password textbox and enter valid password 

            // Fluent Wait Implimentation 
            Wait.Waittobevisible(driver, "Id", "Password", 2);
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");


            //Identify login button and clck on the button 
            // Fluent Wait Implimentation 
            Wait.Waittobeclickable(driver,"Xpath", "//*[@id=\"loginForm\"]/form/div[3]/input[1]", 2);
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

            //Thread.Sleep(1000);

        }
    }
}
