
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalAutomation.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //open the browser 
        IWebDriver driver = new ChromeDriver();

        // Login page object initialization and definition 
        Loginpage loginpageObj = new Loginpage();
        loginpageObj.LoginActions(driver);

        // Home page object initialization and definition
        Homepage homePageobj = new Homepage();
        homePageobj.GoToTMPage(driver);

        // TM page object initialization and definition
        TMpage tmPageObj = new TMpage();
        tmPageObj.createTimeRecord(driver);
        tmPageObj.EditTimeRecord(driver);
        tmPageObj.DeleteTimeRecord(driver);



 









    }
}