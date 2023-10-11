using aruodas.ltOOPInheritance0731vak.Helpers;
using aruodas.ltOOPInheritance0731vak.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace aruodas.ltOOPInheritance0731vak.Tests
{
    internal class flatTests
    {
        public static IWebDriver driver;
        [Test]
        public void fillAddPositiveVilniusFlatTest()
        {
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string Number = "777"; // Objekto numeris
            bool VisibleNumber = false; //Rodyti objekto numerį (true/false)
            string FlatNumber = "55"; // Buto numeris
            bool VisibleFlatNumber = false; //Rodyti buto numerį (true/false)
            int RoomCount = 2; // Kambarių skaičius
            int Floor = 8; // Aukštas
            int TotalFloors = 11; // Viso aukštų
            string YearBuilt = "1984"; // PAstatymo metai
            bool Renovated = false; // Ar renovuotas (true/false)
            int HouseType = 7; // Namo tipas: 1. Brick; 2. Block house; 3.Monolithic; 4. Wooden house; 5. Carcass house; 6. Log house; 7. Panel; 8. Other
            int Equipment = 6; // Įrengimas: 1. Fully equipped; 2. Partially equipped; 3. Not equipped; 4. Under construction; 5. Foundation; 6. Other
            int[] Heating = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Šildymas 1. Central; 2. Electric; 3. Liquid; 4. Central thermostat; 5.Geothermal; 6. Aerothermal; 7. Gas; 8. Solid fuel; 9. Sun energy; 10. Other
            bool Details = false; // Žymėti ypatumus
            int[] Properties = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; // Ypatybės: 1. Private entrance; 2. High ceiling; 3. Flat in an attic; 4. Two-floor flat; 5. Separate bathroom and WC; 6. New sewage system; 7. New electrical installation; 8. Private yard; 9. Internet; 10. Cable television; 11. Kithen merged with room; 12. Part of the apartment
            int[] Premises = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; // Papildomos patalpos: 1. Storeroom; 2. Balcony; 3. Terrace; 4. Cellar; 5. Sauna; 6. Parking space; 7. Attic; 8. Closet 
            int[] AddEquipment = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; //Papildoma įranga:
            int[] Security = new int[] { 1, 2, 3, 4, 5 }; //
            int EnergyClass = 2; // Pastato energijos suvartojimo klasė: 1. Steel doors; 2; Alarm system; 3. Code door lock; 4. Video surveillance; 5. Guard
            string Area = "50"; // Plotas
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = false; // Rodyti unikalų numerį
            string Description = DescriptionGarage.LongDescription; // Aprašymas
            string Youtube = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // 3D nuoroda
            string Price = "500000"; // Kaina
            string PhoNo = "+37065432107"; // Telefono numeris
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = true; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = true; // Sutinku su portalo taisyklėmis

            Flat f = new Flat(Region, Settlement, Microdistrict, Street, Number, VisibleNumber, FlatNumber, VisibleFlatNumber, RoomCount, Floor, TotalFloors, YearBuilt, Renovated, HouseType, Equipment,
                Heating, Details, Properties, Premises, AddEquipment, Security, EnergyClass, Area, RC, VisibleRC, Description, Youtube, TripleDTour, Price, PhoNo, Email, CheckRules, CheckEmail, CheckChat);


            f.fill();
        }

        [Test]
        public void fillAddPositiveKaunasFlatTest()
        {
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string Number = "777"; // Objekto numeris
            bool VisibleNumber = false; //Rodyti objekto numerį (true/false)
            string FlatNumber = "55"; // Buto numeris
            bool VisibleFlatNumber = false; //Rodyti buto numerį (true/false)
            int RoomCount = 2; // Kambarių skaičius
            int Floor = 8; // Aukštas
            int TotalFloors = 11; // Viso aukštų
            string YearBuilt = "1984"; // PAstatymo metai
            bool Renovated = false; // Ar renovuotas (true/false)
            int HouseType = 7; // Namo tipas: 1. Brick; 2. Block house; 3.Monolithic; 4. Wooden house; 5. Carcass house; 6. Log house; 7. Panel; 8. Other
            int Equipment = 6; // Įrengimas: 1. Fully equipped; 2. Partially equipped; 3. Not equipped; 4. Under construction; 5. Foundation; 6. Other
            int[] Heating = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Šildymas 1. Central; 2. Electric; 3. Liquid; 4. Central thermostat; 5.Geothermal; 6. Aerothermal; 7. Gas; 8. Solid fuel; 9. Sun energy; 10. Other
            bool Details = false; // Žymėti ypatumus
            int[] Properties = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; // Ypatybės: 1. Private entrance; 2. High ceiling; 3. Flat in an attic; 4. Two-floor flat; 5. Separate bathroom and WC; 6. New sewage system; 7. New electrical installation; 8. Private yard; 9. Internet; 10. Cable television; 11. Kithen merged with room; 12. Part of the apartment
            int[] Premises = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; // Papildomos patalpos: 1. Storeroom; 2. Balcony; 3. Terrace; 4. Cellar; 5. Sauna; 6. Parking space; 7. Attic; 8. Closet 
            int[] AddEquipment = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; //Papildoma įranga:
            int[] Security = new int[] { 1, 2, 3, 4, 5 }; //
            int EnergyClass = 2; // Pastato energijos suvartojimo klasė: 1. Steel doors; 2; Alarm system; 3. Code door lock; 4. Video surveillance; 5. Guard
            bool VisibleRC = false; // Rodyti unikalų numerį
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            string Area = "50"; // Plotas
            string Description = DescriptionGarage.LongDescription; // Aprašymas
            string Youtube = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // 3D nuoroda
            string Price = "500000"; // Kaina
            string PhoNo = "+37065432107"; // Telefono numeris
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = true; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = true; // Sutinku su portalo taisyklėmis

            Flat f = new Flat(Region, Settlement, Microdistrict, Street, Number, VisibleNumber, FlatNumber, VisibleFlatNumber, RoomCount, Floor, TotalFloors, YearBuilt, Renovated, HouseType, Equipment,
                Heating, Details, Properties, Premises, AddEquipment, Security, EnergyClass, Area, RC, VisibleRC, Description, Youtube, TripleDTour, Price, PhoNo, Email, CheckRules, CheckEmail, CheckChat);


            f.fill();
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            if (DriverClass.Driver is not null)
            {
                return;
            }
            DriverClass.Driver = new ChromeDriver();
            //DriverClass.Wait = new WebDriverWait(DriverClass.Driver, TimeSpan.FromSeconds(5));
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