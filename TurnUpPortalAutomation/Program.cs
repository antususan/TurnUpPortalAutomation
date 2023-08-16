
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open the browser 
IWebDriver driver = new ChromeDriver();
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
Thread.Sleep(5000);

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


// Create a new time record 

// Navigate to Time and Material Module 
IWebElement administrariondropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrariondropdown.Click();

IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();
//click on create button 

IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createnewbutton.Click();

//Select time from dropdown
IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typecodedropdown.Click();

IWebElement timetypecode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timetypecode.Click();

//Enter code
IWebElement codetexbox = driver.FindElement(By.Id("Code"));
codetexbox.SendKeys("August16th");

//Enter Description 
IWebElement descriptiontexbox = driver.FindElement(By.Id("Description"));
descriptiontexbox.SendKeys("August16th");

// Enter Price 
IWebElement pricetextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
pricetextbox.SendKeys("12");

//Click on save button 
IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
savebutton.Click();

Thread.Sleep(5000);

//check if new time record has been created suceesfully 

IWebElement gotolastbutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotolastbutton.Click();

IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


if (newcode.Text == "August16th")
{
    Console.WriteLine("New Time record has been created sucessfully ");
}
else
{
    Console.WriteLine("Time record has not been created ");

}









