using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using aruodas.ltOOPInheritance0731vak.Helpers;
using aruodas.ltOOPInheritance0731vak.Models;
using OpenQA.Selenium.Support.UI;

namespace aruodas.ltOOPInheritance0731vak.Tests
{
    internal class garageTests
    {
        public static IWebDriver driver;

        [Test]
        public void fillAddPositiveVilniusTest()
        {
            Garage g = new Garage ("Vilnius", "Vilniaus", "Markučiai", "Tauro", "Garage", 4, "Parking lot", "5", "50", "5000000", "+37065432107", "nesakysiu@niekam.ut", "https://www.youtube.com/watch?v=31gM5gjw8A8",
                "https://www.youtube.com/watch?v=31gM5gjw8A8", "1234 - 5678 - 9011:4660", DescriptionGarage.LongDescription, new string[] {"Security", "Automatic gates", "Pit", "Basement", "Water", "Heating", "Exchange", "Auction" },
               new string[] { "Security", "Automatic gates", "Heating", "Lock", "Fenced", "Under the roof", "Storeroom", "Exchange", "Auction"}, 3,  true, true, true);

            g.fill();
        }
               
        [OneTimeSetUp]
        public void Initialize()
        {
            if (DriverClass.Driver is not null)
            {
                return;
            }

            DriverClass.Driver = new ChromeDriver();
            DriverClass.Wait = new WebDriverWait(DriverClass.Driver, TimeSpan.FromSeconds(5));

            driver = DriverClass.Driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Manage().Window.Maximize();
            AcceptCookies();
            Login();
        }

        [OneTimeTearDown]
        public void Clenaup()
        {
            //driver.Quit();
        }
        public void AcceptCookies()
        {
            driver.Navigate().GoToUrl("https://en.aruodas.lt/");
            driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
        }
        public void Login()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[2]/div[1]/div[1]/div/div[2]/div")).Click();
            driver.FindElement(By.Id("userName")).SendKeys("jijojon659@ipniel.com");
            driver.FindElement(By.Id("password")).SendKeys("59959gdgf");
            driver.FindElement(By.Id("loginAruodas")).Click();
        }
    }
}

