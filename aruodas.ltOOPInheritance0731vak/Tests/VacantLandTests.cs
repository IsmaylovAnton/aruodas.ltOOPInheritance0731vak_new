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
    internal class VacantLandTests
    {
        public static IWebDriver driver;

        [Test]
        public void fillAddPositiveVilniusTest()
        {
            string Language = "RU";// Kalba: 1. LT; 2. EN; 3. RU
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string Number = "77"; // Objekto numeris
            bool VisibleNumber = false; //Rodyti objekto numerį (true/false)
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = false; // Rodyti unikalų numerį
            string Area = "50"; // Plotas
            int[] WhatPurpose = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Paskirtis: 1. Namų valda; 2. Daugiabučių statyba; 3. Žemės ūkio; 4. Sklypas soduose; 5. Miškų ūkio; 6. Pramonės; 7. Sandėliavimo; 8. Komercinė; 9. Rekreacinė; 10. Kita
            int[] DetailsDescription = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // Ypatybės: 1. Elektra; 2. Dujos; 3. Vanduo; 4. Kraštinis sklypas; 5. Greta miško; 6. Be pastatų; 7. Geodeziniai matavimai; 8. Su pakrante; 9. Asfaltuotas privažiavimas; 10. Domina keitimas; 11. Varžytinės/Aukcionas
            string Description = DescriptionGarage.LongDescription; // Aprašymas
            string Photo = "C:\\Users\\user\\Desktop\\kauno-r-sav-virbaliskiu-k-metu-g-namu.jpg";// Objekto nuotrauka
            string YoutubeVideo = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; //3D nuoroda
            string Price = "500000"; // Kaina
            string PhoNo = "+37065432107"; // Telefono numeris
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = false; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = false; // Sutinku su portalo taisyklėmis

            VacantLand v = new VacantLand(Language, Region, Settlement, Microdistrict, Street, Number, VisibleNumber, RC, VisibleRC, Area, WhatPurpose, DetailsDescription, Description, Photo,
                 YoutubeVideo, TripleDTour, Price, PhoNo, Email, CheckRules, CheckEmail, CheckChat);

            v.fill();
        }

        [Test]
        public void fillAddPositiveSiauliaiTest()
        {
            string Language = "RU";// Kalba: 1. LT; 2. EN; 3. RU
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string Number = "77"; // Objekto numeris
            bool VisibleNumber = false; //Rodyti objekto numerį (true/false)
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = false; // Rodyti unikalų numerį
            string Area = "50"; // Plotas
            int[] WhatPurpose = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Paskirtis: 1. Namų valda; 2. Daugiabučių statyba; 3. Žemės ūkio; 4. Sklypas soduose; 5. Miškų ūkio; 6. Pramonės; 7. Sandėliavimo; 8. Komercinė; 9. Rekreacinė; 10. Kita
            int[] DetailsDescription = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // Ypatybės: 1. Elektra; 2. Dujos; 3. Vanduo; 4. Kraštinis sklypas; 5. Greta miško; 6. Be pastatų; 7. Geodeziniai matavimai; 8. Su pakrante; 9. Asfaltuotas privažiavimas; 10. Domina keitimas; 11. Varžytinės/Aukcionas
            string Description = DescriptionGarage.LongDescription; // Aprašymas
            string Photo = "C:\\Users\\user\\Desktop\\kauno-r-sav-virbaliskiu-k-metu-g-namu.jpg";// Objekto nuotrauka
            string YoutubeVideo = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; //3D nuoroda
            string Price = "500000"; // Kaina
            string PhoNo = "+37065432107"; // Telefono numeris
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = false; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = false; // Sutinku su portalo taisyklėmis

            VacantLand v = new VacantLand(Language, Region, Settlement, Microdistrict, Street, Number, VisibleNumber, RC, VisibleRC, Area, WhatPurpose, DetailsDescription, Description, Photo,
                 YoutubeVideo, TripleDTour, Price, PhoNo, Email, CheckRules, CheckEmail, CheckChat);

            v.fill();
        }

        [Test]
            public void fillAddPositivePanevezysTest()
        {
            string Language = "RU";// Kalba: 1. LT; 2. EN; 3. RU
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string Number = "77"; // Objekto numeris
            bool VisibleNumber = false; //Rodyti objekto numerį (true/false)
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = false; // Rodyti unikalų numerį
            string Area = "50"; // Plotas
            int[] WhatPurpose = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Paskirtis: 1. Namų valda; 2. Daugiabučių statyba; 3. Žemės ūkio; 4. Sklypas soduose; 5. Miškų ūkio; 6. Pramonės; 7. Sandėliavimo; 8. Komercinė; 9. Rekreacinė; 10. Kita
            int[] DetailsDescription = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // Ypatybės: 1. Elektra; 2. Dujos; 3. Vanduo; 4. Kraštinis sklypas; 5. Greta miško; 6. Be pastatų; 7. Geodeziniai matavimai; 8. Su pakrante; 9. Asfaltuotas privažiavimas; 10. Domina keitimas; 11. Varžytinės/Aukcionas
            string Description = DescriptionGarage.LongDescription; // Aprašymas
            string Photo = "C:\\Users\\user\\Desktop\\kauno-r-sav-virbaliskiu-k-metu-g-namu.jpg";// Objekto nuotrauka
            string YoutubeVideo = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; //3D nuoroda
            string Price = "500000"; // Kaina
            string PhoNo = "+37065432107"; // Telefono numeris
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = false; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = false; // Sutinku su portalo taisyklėmis

            VacantLand v = new VacantLand(Language, Region, Settlement, Microdistrict, Street, Number, VisibleNumber, RC, VisibleRC, Area, WhatPurpose, DetailsDescription, Description, Photo,
                 YoutubeVideo, TripleDTour, Price, PhoNo, Email, CheckRules, CheckEmail, CheckChat);

            v.fill();
        }

        [Test]
        public void fillAddPositiveAlytusTest()
        {
            string Language = "RU";// Kalba: 1. LT; 2. EN; 3. RU
            string Region = "Vilnius"; // Miestas arba rajonas
            string Settlement = "Vilniaus"; // Miestas arba kaimas
            string Microdistrict = "Lazdynai"; // Mikrorajonas
            string Street = "Raguvos"; // Gatvė
            string Number = "77"; // Objekto numeris
            bool VisibleNumber = false; //Rodyti objekto numerį (true/false)
            string RC = "1234 - 5678 - 9011:4660"; //Unikalus daikto numeris
            bool VisibleRC = false; // Rodyti unikalų numerį
            string Area = "50"; // Plotas
            int[] WhatPurpose = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Paskirtis: 1. Namų valda; 2. Daugiabučių statyba; 3. Žemės ūkio; 4. Sklypas soduose; 5. Miškų ūkio; 6. Pramonės; 7. Sandėliavimo; 8. Komercinė; 9. Rekreacinė; 10. Kita
            int[] DetailsDescription = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // Ypatybės: 1. Elektra; 2. Dujos; 3. Vanduo; 4. Kraštinis sklypas; 5. Greta miško; 6. Be pastatų; 7. Geodeziniai matavimai; 8. Su pakrante; 9. Asfaltuotas privažiavimas; 10. Domina keitimas; 11. Varžytinės/Aukcionas
            string Description = DescriptionGarage.LongDescription; // Aprašymas
            string Photo = "C:\\Users\\user\\Desktop\\kauno-r-sav-virbaliskiu-k-metu-g-namu.jpg";// Objekto nuotrauka
            string YoutubeVideo = "https://www.youtube.com/watch?v=31gM5gjw8A8"; // Youtube nuoroda
            string TripleDTour = "https://www.youtube.com/watch?v=31gM5gjw8A8"; //3D nuoroda
            string Price = "500000"; // Kaina
            string PhoNo = "+37065432107"; // Telefono numeris
            string Email = "nesakysiu@niekam.ut"; // Elektros 
            bool CheckRules = false; // Išjungti kontaktavimo el. paštu funkciją skelbime
            bool CheckEmail = true; // Išjungti pokalbių ("chat") funkciją skelbime
            bool CheckChat = false; // Sutinku su portalo taisyklėmis

            VacantLand v = new VacantLand(Language, Region, Settlement, Microdistrict, Street, Number, VisibleNumber, RC, VisibleRC, Area, WhatPurpose, DetailsDescription, Description, Photo,
                 YoutubeVideo, TripleDTour, Price, PhoNo, Email, CheckRules, CheckEmail, CheckChat);

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
