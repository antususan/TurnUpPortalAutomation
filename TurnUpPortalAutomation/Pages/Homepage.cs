using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Pages
{
    public class Homepage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            IWebElement administrarionDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrarionDropdown.Click();

            //Explicit wait implimentation 

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));

            //Fluent wait Implimentation

            Wait.Waittobeclickable(driver,"Xpath ","/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
        public void GoToEmployeesPage(IWebDriver driver)
        {
            IWebElement administrarionDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrarionDropdown.Click();

            Wait.Waittobeclickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a", 7);
            IWebElement employeeOpt = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOpt.Click();

        }
    }
}
