using aruodas.ltOOPInheritance0731vak.Helpers;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V114.Input;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace aruodas.ltOOPInheritance0731vak.Models
{
    internal class Garage : RealEstate
    {
        public string Language { get; set; }
        public string GarageParkPlace { get; set; }
        public string Number { get; set; }
        public bool VisibleNumber { get; set; }
        public string RC { get; set; }
        public bool VisibleRC { get; set; }
        public string Area { get; set; }
        public int GarageDetails { get; set; }
        public int[] GarageProperties { get; set; }
        public int ParkingDetails { get; set; }
        public int[] ParkingProperties { get; set; }
        public string Description { get; set; }
        public string GaragePhoto { get; set; }
        public string ParkingPhoto { get; set; }
        public string YoutubeVideo { get; set; }
        public string TripleDTour { get; set; }
        public string Price { get; set; }
        public string PhoNo { get; set; }
        public string Email { get; set; }

        public Garage(string language, string region, string settlement, string microdistrict, string street, string garageParkPlace, string number, bool visibleNumber, string rc, bool visibleRC, string area, int garageDetails, int[] garageProperties, int parkingDetails, int[] parkingProperties, string description, string garagePhoto, string parkingPhoto, string youtubeVideo, string tripleDTour, string price,
           string phoNo, string email, bool checkRules, bool checkEmail, bool checkChat)
              : base(region, settlement, microdistrict, street, checkRules, checkEmail, checkChat)
        {
            this.Language = language;
            this.GarageParkPlace = garageParkPlace;
            this.Number = number;
            this.VisibleNumber = visibleNumber;
            this.RC = rc;
            this.VisibleRC = visibleRC;
            this.Area = area;
            this.GarageDetails = garageDetails;
            this.GarageProperties = garageProperties;
            this.ParkingDetails = parkingDetails;
            this.ParkingProperties = parkingProperties;
            this.Description = description;
            this.GaragePhoto = garagePhoto;
            this.ParkingPhoto = parkingPhoto;
            this.YoutubeVideo = youtubeVideo;
            this.TripleDTour = tripleDTour;
            this.Price = price;
            this.PhoNo = phoNo;
            this.Email = email;
        }
        public override void fill()
        {
            ChooseLanguage();
            base.fill();
            GarageOrParking();
            Driver.FindElement(By.Name("FHouseNum")).SendKeys(this.Number);
            ToggleVisibleNumber();
            Driver.FindElement(By.Name("RCNumber")).SendKeys(this.RC);
            ToggleVisibleRC();
            Driver.FindElement(By.Id("fieldFAreaOverAll")).SendKeys(this.Area);
            Driver.FindElement(By.Name("notes_lt")).SendKeys(DescriptionGarage.LongDescription);
            ObjectGaragePhoto();
            ObjectParkingPhoto();
            Driver.FindElement(By.Name("Video")).SendKeys(this.YoutubeVideo);
            Driver.FindElement(By.Name("tour_3d")).SendKeys(this.TripleDTour);
            ObjectPrice();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[38]/span[1]/input")).SendKeys(this.PhoNo);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/span[1]/input")).Clear();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/span[1]/input")).SendKeys(this.Email);
            //Driver.FindElement(By.Id("submitFormButton")).Click();
        }

        public void ChooseLanguage()
        {
            if (Language == "LT")
            {
                Driver.Navigate().GoToUrl("https://www.aruodas.lt/ideti-skelbima/?obj=13&offer_type=1");
            }
            else if (Language == "EN")
            {
                Driver.Navigate().GoToUrl("https://en.aruodas.lt/ideti-skelbima/?obj=13&offer_type=1");
            }
            else if (Language == "RU")
            {
                Driver.Navigate().GoToUrl("https://ru.aruodas.lt/ideti-skelbima/?obj=13&offer_type=1");
            }
        }
        

            public void ToggleVisibleNumber()
        {
            if (VisibleNumber == true)
                return;
            else
            {
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[8]/div/div/label")).Click();
            }
        }

        public void ToggleVisibleRC()
        {
            if (VisibleRC == true)
            {
                return;
            }
            else
            {
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[12]/div[2]/div/label")).Click();
            }
        }

        public void GarageOrParking()
        {
            if (GarageParkPlace == "Garage")
            {
                GarageType();
                GarageFeatures();
            }
            else if (GarageParkPlace == "Parking place")
            {
                Driver.FindElement(By.XPath("//*[@id=\"whole_building_checkbox\"]/div/label")).Click();
                ParkingType();
                ParkingFeatures();
            }
        }

        public void GarageType()
        {
            switch (GarageDetails)
            {
                case 1: //Stone
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[1]/div[2]")).Click();
                    break;
                case 2: //Iron
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[2]/div[2]")).Click();
                    break;
                case 3: //Underground:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[3]/div[2]")).Click();
                    break;
                case 4: //Multistory:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[4]/div[2]")).Click();
                    break;
                case 5: //Other:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[5]/div[2]")).Click();
                    break;
            }
        }

        public void GarageFeatures()
        {
            Driver.FindElement(By.Id("showMoreFields")).Click();
            Thread.Sleep(1000);
            for (int i = 0; i < GarageProperties.Length; i++)
            {
                switch (GarageProperties[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[5]/label")).Click();
                        break;
                    case 6:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[6]/label")).Click();
                        break;
                    case 7:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[26]/div/div/div/label")).Click();
                        break;
                    case 8:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[27]/div/div/div/label")).Click();
                        break;
                }
            }
        }

        public void ParkingType()
        {
            switch (ParkingDetails)
            {
                case 1: // "Underground parking":
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[1]/div[2]")).Click();
                    break;
                case 2: // "Parking lot":
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[2]/div[2]")).Click();
                    break;
                case 3: // "Multistorey car park":
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[3]/div[2]")).Click();
                    break;
                case 4: //"Other":
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[4]/div[2]")).Click();
                    break;
            }
        }

        public void ParkingFeatures()
        {
            Driver.FindElement(By.Id("showMoreFields")).Click();
            for (int i = 0; i < ParkingProperties.Length; i++)
            {
                switch (ParkingProperties[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[24]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[24]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[24]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[24]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[24]/div/div[5]/label")).Click();
                        break;
                    case 6:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[24]/div/div[6]/label")).Click();
                        break;
                    case 7:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[24]/div/div[7]/label")).Click();
                        break;
                    case 8:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[26]/div/div/div/label")).Click();
                        break;
                    case 9:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[27]/div/div/div/label")).Click();
                        break;
                }
            }
        }

        public void ObjectGaragePhoto()
        {
            IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
            chooseFile.SendKeys(GaragePhoto);
        }

        public void ObjectParkingPhoto()
        {
            IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
            chooseFile.SendKeys(GaragePhoto);
        }

        public void ObjectPrice()
        {
            Driver.FindElement(By.Id("priceField")).SendKeys(this.Price);
        }

    }
}








