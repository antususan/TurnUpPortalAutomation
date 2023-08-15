
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open the browser 
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Launch turnup portal and navigation to login
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

//adding a change 
//Identify username textbox and enter Valid username 
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid password 
IWebElement password = driver.FindElement(By.Id("Password"));
password.SendKeys("123123");

//Identify login button and clck on the button 
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();

//check if the user has logged in sucessfully 
IWebElement Hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (Hellohari.Text == "Hello hari!")
{
    Console.WriteLine("user logged in sucessfully");

}
else
{
    Console.WriteLine("user hasn't been logged in ");
}



