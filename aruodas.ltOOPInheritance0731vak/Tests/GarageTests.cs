using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using aruodas.ltOOPInheritance0731vak.Helpers;
using aruodas.ltOOPInheritance0731vak.Models;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.IO;

namespace aruodas.ltOOPInheritance0731vak.Tests
{
    internal class garageTests
    {
        public static IWebDriver driver;

        [Test]
        public void fillAddPositiveVilniusGarageTest()
        {
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdydai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string GarageOrParking = "Garage"; // Garažas ar parkingas
            string Number = "777"; // Objekto numeris
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            string Area = "50"; // Plotas
            int GarageType = 2; // Garažo tipas: 1. Mūrinis; 2. Geležinis; 3. Požeminis; 4. Daugiaukštis; 5. Kita
            int Accommodation = 3; //Telpa automobilių
            string[] GarageFeatures = new string[] { "Security", "Automatic gates", "Pit", "Basement", "Water", "Heating", "Exchange", "Auction" }; // Garažo ypatybės: 1. Apsauga; 2. Automatiniai vartai; 3. Duobė; 4. Rūsys; 5. Vanduo; 6. Šildymas; 7. Domina keitimas; 7. Varžytinės/aukcionas 
            int ParkingType = 1; // Parkingo tipas: 1. Undergound parking; 2. Parking lot; 3. Multistorey car park; 4. Other



            Garage g = new Garage (Region, Settlement, Microdistrict, Street, GarageOrParking, Number, RC, Area, GarageType, Accommodation, GarageFeatures, ParkingType, "5000000", "+37065432107", "nesakysiu@niekam.ut", "https://www.youtube.com/watch?v=31gM5gjw8A8",
                "https://www.youtube.com/watch?v=31gM5gjw8A8", DescriptionGarage.LongDescription, new string[] { "Security", "Automatic gates", "Heating", "Lock", "Fenced", "Under the roof", "Storeroom", "Exchange", "Auction"}, true, true, true);

            g.fill();
        }

        [Test]
        public void fillAddPositiveVilniusParkingTest()
        {
            Garage g = new Garage(Region, Settlement, Microdistrict, Street, GarageOrParking, Number, RC, Area, GarageType, Accommodation, GarageFeatures, Parking, "5000000", "+37065432107", "nesakysiu@niekam.ut", "https://www.youtube.com/watch?v=31gM5gjw8A8",
                "https://www.youtube.com/watch?v=31gM5gjw8A8", "1234 - 5678 - 9011:4660", DescriptionGarage.LongDescription, new string[] { "Security", "Automatic gates", "Pit", "Basement", "Water", "Heating", "Exchange", "Auction"},
                new string[] { "Security", "Automatic gates", "Heating", "Lock", "Fenced", "Under the roof", "Storeroom", "Exchange", "Auction"}, 3, true, true, true);

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

