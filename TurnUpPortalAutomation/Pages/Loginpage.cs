using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalAutomation.Pages
{
    public class Loginpage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            // Launch turnup portal and navigation to login
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");


            //Identify username textbox and enter Valid username 
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //Identify password textbox and enter valid password 
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //Identify login button and clck on the button 
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbutton.Click();

            Thread.Sleep(1000);

        }
    }
}
