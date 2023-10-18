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
using aruodas.ltOOPInheritance0731vak.Helpers.Flat;
using aruodas.ltOOPInheritance0731vak.Helpers.Garage;

namespace aruodas.ltOOPInheritance0731vak.Models
{
    internal class Flat : RealEstate
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        public string Language { get; set; }
        public string Number { get; set; }
        public bool VisibleNumber { get; set; }
        public string FlatNumber { get; set; }
        public bool VisibleFlatNumber { get; set; }
        public string RC { get; set; }
        public bool VisibleRC { get; set; }
        public string Area { get; set; }
        public string RoomCount { get; set; }
        public int Floor { get; set; }
        public int TotalFloors { get; set; }
        public string YearBuilt { get; set; }
        public bool Renovated { get; set; }
        public int HouseType { get; set; }
        public int Equipment { get; set; }
        public int[] Heating { get; set; }
        public bool Details { get; set; }
        public int[] Properties { get; set; }
        public int[] Premises { get; set; }
        public int[] AddEquipment { get; set; }
        public int[] Security { get; set; }
        public int EnergyClass { get; set; }
        public string Description { get; set; }
        public int[] ExchangeAuction { get; set; }
        public string YoutubeVideo { get; set; }
        public string TripleDTour { get; set; }
        public string Price { get; set; }
        public string PhoNo { get; set; }
        public string Email { get; set; }

        public Flat()
        {
            this.Driver = DriverClass.Driver;
            this.Wait = DriverClass.Wait;
        }

        public Flat(string language, string region, string settlement, string microdistrict, string street, string number, bool visibleNumber, string flatNumber, bool visibleFlatNumber, string rc, bool visibleRC, string area, string roomCount, int floor, int totalFloors, string yearBuilt, bool renovated, int houseType,
            int equipment, int[] heating, bool details, int[] properties, int[] premises, int[] addEquipment, int[] security, int energyClass, string description, int[] exchangeAuction, string youtubeVideo, string tripleDTour, string price, string phoNo, string email, bool checkRules, bool checkEmail, bool checkChat)
            : base(region, settlement, microdistrict, street, checkRules, checkEmail, checkChat)
        {
            this.Driver = DriverClass.Driver;
            this.Wait = DriverClass.Wait;

            this.Language = language;
            this.Number = number;
            this.VisibleNumber = visibleNumber;
            this.FlatNumber = flatNumber;
            this.VisibleFlatNumber = visibleFlatNumber;
            this.RoomCount = roomCount;
            this.Floor = floor;
            this.TotalFloors = totalFloors;
            this.YearBuilt = yearBuilt;
            this.Renovated = renovated;
            this.HouseType = houseType;
            this.Equipment = equipment;
            this.Heating = heating;
            this.Details = details;
            this.Properties = properties;
            this.Premises = premises;
            this.AddEquipment = addEquipment;
            this.Security = security;
            this.EnergyClass = energyClass;
            this.Area = area;
            this.RC = rc;
            this.VisibleRC = VisibleRC;
            this.Description = description;
            this.YoutubeVideo = youtubeVideo;
            this.TripleDTour = tripleDTour;
            this.Price = price;
            this.PhoNo = phoNo;
            this.Email = email;
        }

        public virtual void fill()
        {
            ChooseLanguage();
            Driver.Navigate().GoToUrl("https://www.aruodas.lt/ideti-skelbima/?obj=1");
            base.fill();
            Driver.FindElement(By.Name("FHouseNum")).SendKeys(this.Number);
            ToggleVisibleNumber();
            Driver.FindElement(By.Name("FApartNum")).SendKeys(this.FlatNumber);
            ToggleVisibleFlatNumber();
            Driver.FindElement(By.Name("RCNumber")).SendKeys(this.RC);
            ToggleVisibleRC();
            Driver.FindElement(By.Id("fieldFAreaOverAll")).SendKeys(this.Area);
            RoomNmbr();
            Driver.FindElement(By.Name("notes_lt")).SendKeys(this.Description);
            ObjectPrice();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[46]/span[1]/input")).SendKeys(this.PhoNo);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[47]/span[1]/input")).Clear();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[47]/span[1]/input")).SendKeys(this.Email);
            Driver.FindElement(By.Name("Video")).SendKeys(this.YoutubeVideo);
            Driver.FindElement(By.Name("tour_3d")).SendKeys(this.TripleDTour);
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
            if (VisibleFlatNumber == true)
                return;
            else
            {
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[7]/div/div/label")).Click();
            }
        }

        public void ToggleVisibleFlatNumber()
        {
            if (VisibleFlatNumber == true)
                return;
            else
            {
                Driver.FindElement(By.Id("cbshow_apart_num")).Click();
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



        public void RoomNmbr()
        {
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[15]/div/span/input")).SendKeys(RoomCount);
        }
       


        public void ChooseLocation()
        {
            int pos = 3;
            LocationGeneration(0, 0, this.Region);
            Thread.Sleep(1000);
            LocationGeneration(1, 1, this.Settlement);
            try
            {
                LocationGeneration(2, 2, this.Microdistrict);
                Thread.Sleep(1000);
            }
            catch
            {
                pos = 2;
                Console.WriteLine("kvartalo");
            }
           
            try
            {
                LocationGeneration(3, pos, this.Street);
                Thread.Sleep(1000);
            }
            catch
            {
                pos = 3;
                Console.WriteLine("gatves");
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

        public void ObjectPrice()
        {
            Driver.FindElement(By.Id("priceField")).SendKeys(this.Price);
        }

    }

}
