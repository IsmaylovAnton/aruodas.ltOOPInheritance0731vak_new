using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V114.FedCm;
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
            VacantLand v = new VacantLand("Vilnius", "Vilniaus", "Markučiai", "Tauro", "Garage","Multistorey", "5", "50", "Iron", "5000000", "+37065432107", "nesakysiu@niekam.ut", "https://www.youtube.com/watch?v=31gM5gjw8A8",
                "https://www.youtube.com/watch?v=31gM5gjw8A8", "1234 - 5678 - 9011:4660", DescriptionGarage.LongDescription, new string[] { "Security", "Automatic gates", "Pit", "Basement", "Water", "Heating", "Exchange", "Auction" }
                , 3,  true, true, true);

            v.fill();
        }

        [Test]
        public void fillAddPositiveSiauliaiTest()
        {
            VacantLand v = new VacantLand("Šiauliai", "Žaliūkių", "", "Nemuno", "5", "50", "5000000", "+37065432107", "nesakysiu@niekam.ut", "https://www.youtube.com/watch?v=31gM5gjw8A8",
                "https://www.youtube.com/watch?v=31gM5gjw8A8", "1234 - 5678 - 9011:4660", DescriptionGarage.LongDescription,
                new string[] { "Security", "Automatic gates", "Pit", "Basement", "Water", "Heating", "Exchange", "Auction" }, true, true, true);

            v.fill();
        }

        [Test]
        public void fillAddPositivePanevezysTest()
        {
            VacantLand v = new VacantLand("Panevežys", "Panevėžio", "Pramonės", "Alkupio", "5", "50", "5000000", "+37065432107", "nesakysiu@niekam.ut", "https://www.youtube.com/watch?v=31gM5gjw8A8",
                "https://www.youtube.com/watch?v=31gM5gjw8A8", "1234 - 5678 - 9011:4660", DescriptionGarage.LongDescription,
                new string[] { "Residential", "Manufactoring", "Agricultural", "Collective", "Forestrial", "Factory", "Storage", "Commercial", "Recreational", "Other" },
                new string[] { "Electricity", "Gas", "Sewage", "Marginal", "Near forest", "No buildings", "Geodesic", "With coast", "Paved road", "Exchange", "Auction" }, true, true, true);

            v.fill();
        }

        [Test]
        public void fillAddPositiveKaisiadoriuTest()
        {                                                //"Kaišiadorių", "Krečiūnų"  neveikia (Rajonas/Kaimas/Nėra gatvių)
            VacantLand v = new VacantLand("Kaišiadorių", "Baniškių", "", "Vėjų", "5", "50", "5000000", "+37065432107", "nesakysiu@niekam.ut", "https://www.youtube.com/watch?v=31gM5gjw8A8",
                "https://www.youtube.com/watch?v=31gM5gjw8A8", "1234 - 5678 - 9011:4660", DescriptionPlot.LongDescription,
                new string[] { "Residential", "Manufactoring", "Agricultural", "Collective", "Forestrial", "Factory", "Storage", "Commercial", "Recreational", "Other" },
                new string[] { "Electricity", "Gas", "Sewage", "Marginal", "Near forest", "No buildings", "Geodesic", "With coast", "Paved road", "Exchange", "Auction" }, true, true, true);

            v.fill();
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

