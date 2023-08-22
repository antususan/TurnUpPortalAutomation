﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalAutomation.Utilities
{
    public class Wait
    {
        public static void Waittobeclickable(IWebDriver driver ,string locatortype ,string locatorvalue,int seconds )
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locatortype == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }

            if (locatortype=="Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }
            if (locatortype=="CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }
            if(locatortype=="Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorvalue)));
            }
            
        }

        public static void Waittobevisible(IWebDriver driver, string locatortype, string locatorvalue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locatortype == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));
            }

            if (locatortype == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));
            }
            if (locatortype == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorvalue)));
            }
            if (locatortype == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorvalue)));
            }

        }

    }
}
