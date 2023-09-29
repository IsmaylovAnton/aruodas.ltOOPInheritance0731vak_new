﻿using aruodas.ltOOPInheritance0731vak.Helpers;
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
        public string City { get; set; }
        public string Settlement { get; set; }
        public string Quarter { get; set; }
        public string Street { get; set; }
        public string GarageParkPlace { get; set; }
        public int GarageDetails { get; set; }
        public string ParkingDetails { get; set; }
        public string Number { get; set; }
        public string Area { get; set; }
        public string Price { get; set; }
        public string PhoNo { get; set; }
        public string Email { get; set; }
        public string Video { get; set; }
        public string Tour { get; set; }
        public string RC { get; set; }
        public string Description { get; set; }
        public string[] GarageProperties { get; set; }
        public string[] ParkingProperties { get; set; }
        public int CarQuantity { get; set; }
        public bool CheckRules { get; set; }
        public bool CheckEmail { get; set; }
        public bool CheckChat { get; set; }

        public Garage (string city, string settlement, string quarter, string street, string garageParkPlace, int garageDetails, string parkingDetails, string number, string area, string price, string phoNo, string email, string video, string tour, string rc, string description, string[] garageProperties,
            string[]parkingProperties, int carQuantity, bool checkRules, bool checkEmail, bool checkChat) : base()
        {
            this.City = city;
            this.Settlement = settlement;
            this.Quarter = quarter;
            this.Street = street;
            this.GarageParkPlace = garageParkPlace;
            this.GarageDetails = garageDetails;
            this.ParkingDetails = parkingDetails;
            this.Number = number;
            this.Area = area;
            this.Price = price;
            this.PhoNo = phoNo;
            this.Email = email;
            this.Video = video;
            this.Tour = tour;
            this.RC = rc;
            this.Description = description;
            this.GarageProperties = garageProperties;
            this.ParkingProperties = parkingProperties;
            this.CarQuantity = carQuantity;
            this.CheckRules = true;
            this.CheckEmail = true;
            this.CheckChat = true;
        }
        public void fill()
        {
            Driver.Navigate().GoToUrl("https://en.aruodas.lt/ideti-skelbima/?obj=13&offer_type=1");
            ChooseLocation();
            GarageOrParking();
            Driver.FindElement(By.Name("FHouseNum")).SendKeys(this.Number);
            Driver.FindElement(By.Name("RCNumber")).SendKeys(this.RC);
            Driver.FindElement(By.Id("fieldFAreaOverAll")).SendKeys(this.Area);
            Driver.FindElement(By.Name("notes_lt")).SendKeys(this.Description);
            Driver.FindElement(By.Name("Video")).SendKeys(this.Video);
            Driver.FindElement(By.Name("tour_3d")).SendKeys(this.Tour);
            Driver.FindElement(By.Id("priceField")).SendKeys(this.Price);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[38]/span[1]/input")).SendKeys(this.PhoNo);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[38]/span[1]/input")).Clear();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/span[1]/input")).SendKeys(this.Email);
            Accommodates();
            emailCheck();
            chatCheck();
            agreeToRUles();
            Photo();
            Driver.FindElement(By.Id("submitFormButton")).Click();
        }
        public void Accommodates()
        {
            switch (CarQuantity)
            {
                case 1:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[1]/div[2]")).Click();
                    break;
                case 2:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[2]/div[2]")).Click();
                    break;
                case 3:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[3]/div[2]")).Click();
                    break;
                case 4:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[4]/div[2]")).Click();
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
                ParkingType();
                ParkingFeatures();
            }
        }




        public void LocationGeneration(int xpath, int pos, string searchText)
        {
            string[] Xpaths = { "//*[@id=\"newObjectForm\"]/ul/li[3]/span[1]/span", "//*[@id=\"district\"]/span", "//*[@id=\"quartalField\"]/span[1]/span[2]", "//*[@id=\"streetField\"]/span[1]/span[2]" };
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath(Xpaths[xpath])).Click();
            IWebElement containerElement = Driver.FindElements(By.ClassName("dropdown-input-values-address"))[pos];
            IList<IWebElement> elements = containerElement.FindElements(By.TagName("li"));

            if (elements.Count > 19)
            {
                containerElement.FindElement(By.TagName("input")).SendKeys(searchText);
                Thread.Sleep(1000);
                containerElement.FindElement(By.TagName("input")).SendKeys(Keys.Enter);
            }
            else
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i].Text.Contains(searchText))
                    {
                        elements[i].Click();
                        break;
                    }
                }
            }
        }

        public void ChooseLocation()
        {
            int pos = 3;
            LocationGeneration(0, 0, this.City);
            Thread.Sleep(1000);
            LocationGeneration(1, 1, this.Settlement);
            try
            {
                LocationGeneration(2, 2, this.Quarter);
                Thread.Sleep(1000);
            }
            catch
            {
                pos = 2;
                Console.WriteLine("neradom 3-cio");
            }
            LocationGeneration(3, pos, this.Street);
        }

        public void GarageType()
        {
            {
                Driver.FindElement(By.XPath("//*[@id=\"showMoreFields\"]/span")).Click();
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
            }
        }


        public void GarageFeatures()
        {
            Driver.FindElement(By.XPath("//*[@id=\"showMoreFields\"]/span")).Click();
          
            for (int i = 0; i < GarageProperties.Length; i++)

            
                switch (GarageProperties[i])
                {
                    case "Security":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[1]/label")).Click();
                        break;
                    case "Automatic gates":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[2]/label")).Click();
                        break;
                    case "Pit":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[3]/label")).Click();
                        break;
                    case "Basement":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[4]/label")).Click();
                        break;
                    case "Water":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[5]/label")).Click();
                        break;
                    case "Heating":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[6]/label")).Click();
                        break;
                    case "Exchange":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[7]/label")).Click();
                        break;
                    case "Auction":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div[8]/label")).Click();
                        break;

                }
        }

        public void ParkingType()
        {
            {
                Driver.FindElement(By.XPath("//*[@id=\"showMoreFields\"]/span")).Click();
                {
                    switch (ParkingDetails)
                    {
                        case "Underground parking":
                            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[1]/div[2]")).Click();
                            break;
                        case "Parking lot":
                            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[2]/div[2]")).Click();
                            break;
                        case "Multistorey car park":
                            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[3]/div[2]")).Click();
                            break;
                        case "Other":
                            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[4]/div[2]")).Click();
                            break;
                    }
                }
            }
        }

        public void ParkingFeatures()
        {
            Driver.FindElement(By.XPath("//*[@id=\"showMoreFields\"]/span")).Click();
            for (int i = 0; i < GarageProperties.Length; i++)
            {
                switch (ParkingProperties[i])
                {
                    case "Security":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[1]/label")).Click();
                        break;
                    case "Automatic gates":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[2]/label")).Click();
                        break;
                    case "Pit":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[3]/label")).Click();
                        break;
                    case "Basement":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[4]/label")).Click();
                        break;
                    case "Water":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[5]/label")).Click();
                        break;
                    case "Heating":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[6]/label")).Click();
                        break;
                    case "Exchange":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[7]/label")).Click();
                        break;
                    case "Auction":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[8]/label")).Click();
                        break;

                }
            }
        }


        

        public void Photo()
        {
            IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
            chooseFile.SendKeys("C:\\Users\\user\\Desktop\\Garazgaraziukas.png");
        }

        public void emailCheck()
        {
            IWebElement emailCheckbox = Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[40]/span/label/span"));

            if (!emailCheckbox.Selected)
            {
                emailCheckbox.Click();
            }
        }

        public void chatCheck()
        {
            IWebElement chatCheckbox = Driver.FindElement(By.Id("cbdont_want_chat"));
            IWebElement emailCheckboxLabel = Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[41]/div/div/div/label/span"));

            if (!chatCheckbox.Selected)
            {
                emailCheckboxLabel.Click();
            }
        }
        public void agreeToRUles()
        {
            IWebElement agreeToRulesCheckbox = Driver.FindElement(By.Id("cbagree_to_rules"));
            IWebElement agreeToRulesCheckboxLabel = Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[42]/span[1]/div/div/label/span"));

            if (!agreeToRulesCheckbox.Selected)
            {
                agreeToRulesCheckboxLabel.Click();
            }
        }

    }
}








