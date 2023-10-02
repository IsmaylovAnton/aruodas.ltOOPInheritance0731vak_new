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
using SeleniumExtras.WaitHelpers;

namespace aruodas.ltOOPInheritance0731vak.Models
{
    internal class Garage : RealEstate
    {
        public string GarageParkPlace { get; set; }
        public string RC { get; set; }
        public string Area { get; set; }
        public int GarageDetails { get; set; }
        public int CarQuantity { get; set; }
        public int[] GarageProperties { get; set; }
        public int ParkingDetails { get; set; }
        public int[] ParkingProperties { get; set; }
        public string PhoNo { get; set; }
        public string Email { get; set; }

        public Garage(string city, string settlement, string quarter, string street, string garageParkPlace, string number, string rc, string area, int garageDetails, int carQuantity, int[] garageProperties, int parkingDetails, int[] parkingProperties, string description, string youtubeVideo, string tripleDTour, string price, 
            string phoNo, string email, bool checkRules, bool checkEmail, bool checkChat) 
            : base(city, settlement, quarter, street, number, description, youtubeVideo, tripleDTour, price, checkRules, checkEmail, checkChat)
        {
            this.GarageParkPlace = garageParkPlace;
            this.RC = rc;
            this.Area = area;
            this.GarageDetails = garageDetails;
            this.CarQuantity = carQuantity;
            this.GarageProperties = garageProperties;
            this.ParkingDetails = parkingDetails;
            this.ParkingProperties = parkingProperties;
            this.PhoNo = phoNo;
            this.Email = email;
            
        }
        public void fill()
        {
            Driver.Navigate().GoToUrl("https://www.aruodas.lt/ideti-skelbima/?obj=13&offer_type=1");
            base.fill(); 
            GarageOrParking();
            Driver.FindElement(By.Name("RCNumber")).SendKeys(this.RC);
            Driver.FindElement(By.Id("fieldFAreaOverAll")).SendKeys(this.Area);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[38]/span[1]/input")).SendKeys(this.PhoNo);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/span[1]/input")).Clear();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/span[1]/input")).SendKeys(this.Email);
            Accommodation();
            Photo();
            //Driver.FindElement(By.Id("submitFormButton")).Click();
        }
        public void Accommodation()
        {
            switch (CarQuantity)
            {
                case 1:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[1]/div[2]")).Click();
                    break;
                case 2:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[18]/div/div[2]/div[2]")).Click();
                    break;
                case 3:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[18]/div/div[3]/div[2]")).Click();
                    break;
                case 4:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[18]/div/div[4]/div[2]")).Click();
                    break;

                default:
                    {
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[18]/div/span/div")).SendKeys(CarQuantity + "");
                        break;
                    }
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


        public void Photo()
        {
            IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
            chooseFile.SendKeys("C:\\Users\\user\\Desktop\\Aruodas\\Garaz\\sip-medinis-garazas-3.jpg");
        }
        
    }
}








