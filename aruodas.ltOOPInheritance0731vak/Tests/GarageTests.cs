﻿using aruodas.ltOOPInheritance0731vak.Helpers;
using aruodas.ltOOPInheritance0731vak.Helpers.Garage;
using aruodas.ltOOPInheritance0731vak.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace aruodas.ltOOPInheritance0731vak.Tests
{
    internal class garageTests
    {
        public static IWebDriver driver;
        [Test]
        public void fillAddPositiveVilniusGarageTest()
        {
            string Language = "EN";// Kalba: 1. LT; 2. EN; 3. RU
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string GarageParkPlace = "Garage"; // 1. Garage; 2. Parkingas
            string Number = "777"; // Objekto numeris
            bool VisibleNumber = true; //Rodyti objekto numerį (true/false)
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = true; // Rodyti unikalų numerį
            string Area = "50"; // Plotas
            int GarageDetails = 3; // Garažo tipas: 1. Mūrinis; 2. Geležinis; 3. Požeminis; 4. Daugiaukštis; 5. Kita
            string Accomodation = "5"; // Kiek telpa automobilių
            int[] GarageProperties = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; // Garažo ypatybės: 1. Apsauga; 2. Automatiniai vartai; 3. Duobė; 4. Rūsys; 5. Vanduo; 6. Šildymas; 7. Domina keitimas; 8. Varžytinės/aukcionas 
            int ParkingDetails = 1; // Parkingo tipas: 1. Požeminėje aikštelėje; 2. Antžeminėje aikštelėje; 3. Daugiaaukštėje aikštelėje; 4. Kita
            int[] ParkingProperties = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 1. Apsauga; 2. Automatiniai vartai; 3. Šildymas; 4. Užraktas; 5. Aptverta; 6. Po stogu; 7. Su sandėliuku; 8. Domina keitimas; 9. Varžytinės/aukcionas 
            string GaragePhoto = "C:\\Users\\user\\Desktop\\Aruodas\\Garaz\\sip-medinis-garazas-3.jpg";// Garažo nuotrauka
            string ParkingPhoto = "C:\\Users\\user\\Desktop\\Aruodas\\Garaz\\parkingas.jpg";// Parkingo nuotrauka
            string Youtube = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // 3D nuoroda
            string Price = "500000"; // Kaina
            string PhoNo = "+37065432107"; // Telefono numeris
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = true; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = true; // Sutinku su portalo taisyklėmis


            Garage g = new Garage(Language, Region, Settlement, Microdistrict, Street, GarageParkPlace, Number, VisibleNumber, RC, VisibleRC, Area, GarageDetails, Accomodation, GarageProperties, ParkingDetails, ParkingProperties, GaragePhoto, ParkingPhoto, Youtube, TripleDTour, Price, PhoNo, Email, CheckRules, CheckEmail, CheckChat);

            g.fill();
        }

        [Test]
        public void fillAddPositiveKaunasParkingTest()
        {
            string Language = "LT";// Kalba: 1. LT; 2. EN; 3. RU
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string GarageParkPlace = "Parking place"; // 1. Garage; 2. Parking place
            string Number = "777"; // Objekto numeris
            bool VisibleNumber = true; //Rodyti objekto numerį (true/false)
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = true; // Rodyti unikalų numerį
            string Area = "50"; // Plotas
            int GarageDetails = 3; // Garažo tipas: 1. Mūrinis; 2. Geležinis; 3. Požeminis; 4. Daugiaukštis; 5. Kita
            string Accomodation = "4"; // Kiek telpa automobilių
            int[] GarageProperties = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; // Garažo ypatybės: 1. Apsauga; 2. Automatiniai vartai; 3. Duobė; 4. Rūsys; 5. Vanduo; 6. Šildymas; 7. Domina keitimas; 8. Varžytinės/aukcionas 
            int ParkingDetails = 2; // Parkingo tipas: 1. Požeminėje aikštelėje; 2. Antžeminėje aikštelėje; 3. Daugiaaukštėje aikštelėje; 4. Kita
            int[] ParkingProperties = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 1. Apsauga; 2. Automatiniai vartai; 3. Šildymas; 4. Užraktas; 5. Aptverta; 6. Po stogu; 7. Su sandėliuku; 8. Domina keitimas; 9. Varžytinės/aukcionas 
            string GaragePhoto = "C:\\Users\\user\\Desktop\\Aruodas\\Garaz\\sip-medinis-garazas-3.jpg";// Garažo nuotrauka
            string ParkingPhoto = "C:\\Users\\user\\Desktop\\Aruodas\\Garaz\\parkingas.jpg";// Parkingo nuotrauka
            string Youtube = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // 3D nuoroda
            string Price = "500000"; // Kaina
            string PhoNo = "+37065432107"; // Telefono numeris
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = true; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = true; // Sutinku su portalo taisyklėmis


            Garage g = new Garage(Language, Region, Settlement, Microdistrict, Street, GarageParkPlace, Number, VisibleNumber, RC, VisibleRC, Area, GarageDetails, Accomodation, GarageProperties, ParkingDetails, ParkingProperties, GaragePhoto, ParkingPhoto, Youtube, TripleDTour, Price, PhoNo, Email, CheckRules, CheckEmail, CheckChat);

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