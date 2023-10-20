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
            string Language = "RU";// Kalba: 1. LT; 2. EN; 3. RU
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string Number = "777"; // Objekto numeris
            bool VisibleNumber = false; //Rodyti objekto numerį (true/false)
            string FlatNumber = "11"; // Buto numeris
            bool VisibleFlatNumber = true; //Rodyti buto numerį (true/false)
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = true; // Rodyti unikalų numerį
            string Area = "50"; // Plotas
            string RoomCount = "8"; // Kambarių skaičius
            string Floor = "18"; // Aukštas
            string TotalFloors = "19"; // Viso aukštų
            string YearBuilt = "1984"; // Pastatymo metai
            bool Renovated = true; // Ar renovuotas? (true/false)
            string WhenRenovated = "2015";// Kelintais metais renovuotas?
            int HouseType = 7; // Namo tipas: 1. Brick; 2. Block house; 3.Monolithic; 4. Wooden house; 5. Carcass house; 6. Log house; 7. Panel; 8. Other
            int Equipment = 6; // Įrengimas: 1. Fully equipped; 2. Partially equipped; 3. Not equipped; 4. Under construction; 5. Foundation; 6. Other
            int[] Heating = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Šildymas 1. Central; 2. Electric; 3. Liquid; 4. Central thermostat; 5.Geothermal; 6. Aerothermal; 7. Gas; 8. Solid fuel; 9. Sun energy; 10. Other
            bool Details = true; // Žymėti ypatumus
            int[] Properties = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; // Ypatybės: 1. Private entrance; 2. High ceiling; 3. Flat in an attic; 4. Two-floor flat; 5. Separate bathroom and WC; 6. New sewage system; 7. New electrical installation; 8. Private yard; 9. Internet; 10. Cable television; 11. Kithen merged with room; 12. Part of the apartment
            int[] Premises = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; // Papildomos patalpos: 1. Storeroom; 2. Balcony; 3. Terrace; 4. Cellar; 5. Sauna; 6. Parking space; 7. Attic; 8. Closet 
            int[] AddEquipment = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; //Papildoma įranga: 1. Conditioner; 2. Washing machine; 3. Furniture; 4. Refrigerator; 5. Floor heating system; 6. Kitchen furniture; 7. Stove; 8. Fireplace; 9. Plastic pipes; 10. Dish washer; 11. Shower; 12. Bath; 13. Recuperation
            int[] Security = new int[] { 1, 2, 3, 4, 5 }; // Apsauga: 1. Steel doors; 2; Alarm system; 3. Code door lock; 4. Video surveillance; 5. Guard  
            int EnergyClass = 3; // Pastato energijos suvartojimo klasė: 1. A++; 2. A+; 3. B; 4. C; 5. D; 6. E; 7. F; 8. G
            bool Exchange = true; // Interested in exchange;
            bool Auction = true; // Sale by auction 
            string FlatPhoto = "C:\\Users\\user\\Desktop\\Aruodas\\Garaz\\vilnius-tarande-uzubaliu-g-3-rooms-flat.jpg"; // Nuotrauka
            string Youtube = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // 3D nuoroda
            string Price = "500000"; // Kaina
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = true; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = true; // Sutinku su portalo taisyklėmis
            string PhoNo = "+37065432107"; // Telefono numeris

            Flat f = new Flat(Language, Region, Settlement, Microdistrict, Street, Number, VisibleNumber, FlatNumber, VisibleFlatNumber, RC, VisibleRC, Area, RoomCount, Floor, TotalFloors, YearBuilt, Renovated, WhenRenovated, HouseType, Equipment,
                Heating, Details, Properties, Premises, AddEquipment, Security, EnergyClass, Exchange, Auction, FlatPhoto, Youtube, TripleDTour, Price, Email, CheckRules, CheckEmail, CheckChat, PhoNo);


            f.fill();
        }

        [Test]
        public void fillAddPositiveKaunasFlatTest()
        {
            string Language = "EN";// Kalba: 1. LT; 2. EN; 3. RU
            string Region = "Kaunas"; // Miestas arba rajonas
            string Settlement = "Kauno"; // Miestas arba kaimas
            string Microdistrict = "Eguliai"; // Mikrorajonas
            string Street = "Baranausko"; // Gatvė
            string Number = "55"; // Objekto numeris
            bool VisibleNumber = false; //Rodyti objekto numerį (true/false)
            string FlatNumber = "11"; // Buto numeris
            bool VisibleFlatNumber = true; //Rodyti buto numerį (true/false)
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = true; // Rodyti unikalų numerį
            string Area = "50"; // Plotas
            string RoomCount = "8"; // Kambarių skaičius
            string Floor = "18"; // Aukštas
            string TotalFloors = "19"; // Viso aukštų
            string YearBuilt = "1984"; // Pastatymo metai
            bool Renovated = true; // Ar renovuotas? (true/false)
            string WhenRenovated = "2015";// Kelintais metais renovuotas?
            int HouseType = 7; // Namo tipas: 1. Brick; 2. Block house; 3.Monolithic; 4. Wooden house; 5. Carcass house; 6. Log house; 7. Panel; 8. Other
            int Equipment = 6; // Įrengimas: 1. Fully equipped; 2. Partially equipped; 3. Not equipped; 4. Under construction; 5. Foundation; 6. Other
            int[] Heating = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Šildymas 1. Central; 2. Electric; 3. Liquid; 4. Central thermostat; 5.Geothermal; 6. Aerothermal; 7. Gas; 8. Solid fuel; 9. Sun energy; 10. Other
            bool Details = true; // Žymėti ypatumus
            int[] Properties = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; // Ypatybės: 1. Private entrance; 2. High ceiling; 3. Flat in an attic; 4. Two-floor flat; 5. Separate bathroom and WC; 6. New sewage system; 7. New electrical installation; 8. Private yard; 9. Internet; 10. Cable television; 11. Kithen merged with room; 12. Part of the apartment
            int[] Premises = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; // Papildomos patalpos: 1. Storeroom; 2. Balcony; 3. Terrace; 4. Cellar; 5. Sauna; 6. Parking space; 7. Attic; 8. Closet 
            int[] AddEquipment = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; //Papildoma įranga: 1. Conditioner; 2. Washing machine; 3. Furniture; 4. Refrigerator; 5. Floor heating system; 6. Kitchen furniture; 7. Stove; 8. Fireplace; 9. Plastic pipes; 10. Dish washer; 11. Shower; 12. Bath; 13. Recuperation
            int[] Security = new int[] { 1, 2, 3, 4, 5 }; // Apsauga: 1. Steel doors; 2; Alarm system; 3. Code door lock; 4. Video surveillance; 5. Guard  
            int EnergyClass = 3; // Pastato energijos suvartojimo klasė: 1. A++; 2. A+; 3. B; 4. C; 5. D; 6. E; 7. F; 8. G
            bool Exchange = true; // Interested in exchange;
            bool Auction = true; // Sale by auction 
            string FlatPhoto = "C:\\Users\\user\\Desktop\\Aruodas\\Garaz\\vilnius-tarande-uzubaliu-g-3-rooms-flat.jpg"; // Nuotrauka
            string Youtube = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // 3D nuoroda
            string Price = "500000"; // Kaina
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = true; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = true; // Sutinku su portalo taisyklėmis
            string PhoNo = "+37065432107"; // Telefono numeris

            Flat f = new Flat(Language, Region, Settlement, Microdistrict, Street, Number, VisibleNumber, FlatNumber, VisibleFlatNumber, RC, VisibleRC, Area, RoomCount, Floor, TotalFloors, YearBuilt, Renovated, WhenRenovated, HouseType, Equipment,
                Heating, Details, Properties, Premises, AddEquipment, Security, EnergyClass, Exchange, Auction, FlatPhoto, Youtube, TripleDTour, Price, Email, CheckRules, CheckEmail, CheckChat, PhoNo);

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