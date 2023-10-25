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
using aruodas.ltOOPInheritance0731vak.Helpers.House;
using Microsoft.VisualBasic;

namespace aruodas.ltOOPInheritance0731vak.Models
{
    internal class House : RealEstate
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        public string Language { get; set; }
        public string Number { get; set; }
        public bool VisibleNumber { get; set; }
        public string RC { get; set; }
        public bool VisibleRC { get; set; }
        public string Area { get; set; }
        public string TotalFloors { get; set; }
        public string PlotArea { get; set; }
        public bool WithoutLand { get; set; }
        public string YearBuilt { get; set; }
        public bool Renovated { get; set; }
        public string WhenRenovated { get; set; }
        public int BuildingType {  get; set; }  
        public int HouseType {  get; set; } 
        public int Equipment { get; set; }
        public int[] Heating { get; set; }
        public bool Details { get; set; }
        public string RoomCount { get; set; }
        public int WaterBody {  get; set; }  
        public string DistanceFromWater {  get; set; }  
        public int[] WaterSystem {  get; set; }   
        public int[] Properties { get; set; }
        public int[] Premises { get; set; }
        public int[] AddEquipment { get; set; }
        public int[] Security { get; set; }
        public int EnergyClass { get; set; }
        public bool Exchange { get; set; }
        public bool Auction {  get; set; }  
        public string FlatPhoto { get; set; }
        public string YoutubeVideo { get; set; }
        public string TripleDTour { get; set; }
        public string Price { get; set; }
        public string Email { get; set; }
        public string PhoNo { get; set; }

        public House()
        {
            this.Driver = DriverClass.Driver;
            this.Wait = DriverClass.Wait;
        }

        public House(string language, string region, string settlement, string microdistrict, string street, string number, bool visibleNumber, string rc, bool visibleRC, string area, string totalFloors, string plotArea, bool withoutLand, string yearBuilt, bool renovated, string whenRenovated, int buildingType, int houseType, int equipment,
            int[] heating, bool details, string roomCount, int waterBody, string distanceFromWater, int[] waterSystem, int[] properties, int[] premises, int[] addEquipment, int[] security, int energyClass, bool exchange, bool auction, string flatPhoto, string youtubeVideo, string tripleDTour, string price, string email, bool checkRules, bool checkEmail, bool checkChat, string phoNo)
            : base(region, settlement, microdistrict, street, checkRules, checkEmail, checkChat)
        {
            this.Driver = DriverClass.Driver;
            this.Wait = DriverClass.Wait;

            this.Language = language;
            this.Number = number;
            this.VisibleNumber = visibleNumber;
            this.RC = rc;
            this.VisibleRC = VisibleRC;
            this.Area = area;
            this.TotalFloors = totalFloors;
            this.PlotArea = plotArea;
            this.WithoutLand = withoutLand;
            this.YearBuilt = yearBuilt;
            this.Renovated = renovated;
            this.WhenRenovated = whenRenovated;
            this.BuildingType = buildingType;
            this.HouseType = houseType;
            this.Equipment = equipment;
            this.Heating = heating;
            this.RoomCount = roomCount;
            this.Details = details;
            this.WaterBody = waterBody;
            this.DistanceFromWater = distanceFromWater;
            this.WaterSystem = waterSystem;
            this.Properties = properties;
            this.Premises = premises;
            this.AddEquipment = addEquipment;
            this.Security = security;
            this.EnergyClass = energyClass;
            this.Exchange = exchange;
            this.Auction = auction;
            this.FlatPhoto = flatPhoto;
            this.YoutubeVideo = youtubeVideo;
            this.TripleDTour = tripleDTour;
            this.Price = price;
            this.Email = email;
            this.PhoNo = phoNo;
        }

        public virtual void fill()
        {
            ChooseLanguage();
            base.fill();
            Driver.FindElement(By.Name("FHouseNum")).SendKeys(this.Number);
            ToggleVisibleNumber();
            Driver.FindElement(By.Name("RCNumber")).SendKeys(this.RC);
            ToggleVisibleRC();
            Driver.FindElement(By.XPath("//*[@id=\"fieldFAreaOverAll\"]")).SendKeys(this.Area);
            PArea();
            DetailsOnOff();
            Heat();
            RoomNmbr();
            BodyOfWater();
            WaterSys();
            Floors();
            Year();
            Renovation();
            BTYpe();
            Type();
            Equip();
            Prop();
            AddPremises();
            EquipmentAdd();
            SecuritySystems();
            Energy();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[52]/span[1]/input")).SendKeys(this.PhoNo);
            Description();
            ObjectPrice();
            Change();
            Auctioner();
            ObjectPhoto();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[53]/span[1]/input")).Clear();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[53]/span[1]/input")).SendKeys(this.Email);
            Driver.FindElement(By.Name("Video")).SendKeys(this.YoutubeVideo);
            Driver.FindElement(By.Name("tour_3d")).SendKeys(this.TripleDTour);
            //Driver.FindElement(By.Id("submitFormButton")).Click();
        }

        public void ChooseLanguage()
        {
            if (Language == "LT")
            {
                Driver.Navigate().GoToUrl("https://www.aruodas.lt/ideti-skelbima/?obj=2");
            }
            else if (Language == "EN")
            {
                Driver.Navigate().GoToUrl("https://en.aruodas.lt/ideti-skelbima/?obj=2");
            }
            else if (Language == "RU")
            {
                Driver.Navigate().GoToUrl("https://ru.aruodas.lt/ideti-skelbima/?obj=2");
            }
        }

        public void DetailsOnOff()
        {
            if (Details == true)
                Driver.FindElement(By.Id("showMoreFields")).Click();
            else
            {
                return;
            }
        }

        public void ToggleVisibleNumber()
        {
            if (VisibleNumber == true)
                return;
            else
            {
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[7]/div/div/label")).Click();
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
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[11]/div[2]/div/label")).Click();
            }
        }

        public void PArea()
        {
            Driver.FindElement(By.XPath("//*[@id=\"fieldFAreaLot\"]")).SendKeys(this.PlotArea);
            if (WithoutLand == false)
            {
                return;
            }
            else
            {
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[15]/div/div/label")).Click();

            }
        }

        public void RoomNmbr()
        {
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[25]/div/span/input")).SendKeys(RoomCount);
        }

        public void BodyOfWater()
        {
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[27]/span[1]/input")).SendKeys(DistanceFromWater);
            switch (WaterBody)
            {
                case 1:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[26]/div/div[1]/div[2]")).Click();
                    break;
                case 2:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[26]/div/div[2]/div[2]")).Click();
                    break;
                case 3:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[26]/div/div[3]/div[2]")).Click();
                    break;
                case 4:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[26]/div/div[4]/div[2]")).Click();
                    break;
            }
        }
        public void WaterSys()
        {

            for (int i = 0; i < WaterSystem.Length; i++)
            {
                switch (WaterSystem[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[29]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[29]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[29]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[29]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[29]/div/div[5]/label")).Click();
                        break;
                }
            }
        }

        public void Floors()
        {
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[14]/div/span/input")).SendKeys(TotalFloors);
        }

        public void Year()
        {
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div[1]/span[1]/span/input")).SendKeys(YearBuilt);
        }

        public void Renovation()
        {
            if (Renovated == false)
                return;
            else
            {
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div[2]/div/div/label")).Click();
                Driver.FindElement(By.XPath("//*[@id=\"FRenovatedYear\"]")).SendKeys(WhenRenovated);
            }
        }

        public void BTYpe()
        {
            switch(BuildingType)
            {
                case 1:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[1]/div[2]")).Click();
                    break;
                case 2:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[2]/div[2]")).Click();
                    break;
                case 3:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[3]/div[2]")).Click();
                    break;
                case 4:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[4]/div[2]")).Click();
                    break;
                case 5:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[5]/div[2]")).Click();
                    break;
                case 6:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[6]/div[2]")).Click();
                    break;
            }
        }

        public void Type()
        {
            switch (HouseType)
            {
                case 1:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[18]/div/div[1]/div[2]")).Click();
                    break;
                case 2:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[18]/div/div[2]/div[2]")).Click();
                    break;
                case 3:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[3]/div[2]")).Click();
                    break;
                case 4:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[4]/div[2]")).Click();
                    break;
                case 5:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[5]/div[2]")).Click();
                    break;
                case 6:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[6]/div[2]")).Click();
                    break;
                case 7:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[18]/div/div[7]/div[2]")).Click();
                    break;
                case 8:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[17]/div/div[8]/div[2]")).Click();
                    break;
            }
        }

        public void Equip()
        {
            switch (Equipment)
            {
                case 1:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[19]/div/div[1]/div[2]")).Click();
                    break;
                case 2:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[19]/div/div[2]/div[2]")).Click();
                    break;
                case 3:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[19]/div/div[3]/div[2]")).Click();
                    break;
                case 4:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[19]/div/div[4]/div[2]")).Click();
                    break;
                case 5:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[19]/div/div[5]/div[2]")).Click();
                    break;
                case 6:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[19]/div/div[6]/div[2]")).Click();
                    break;
            }
        }
        public void Heat()
        {

            for (int i = 0; i < Heating.Length; i++)
            {
                switch (Heating[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[5]/label")).Click();
                        break;
                    case 6:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[6]/label")).Click();
                        break;
                    case 7:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[7]/label")).Click();
                        break;
                    case 8:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[8]/label")).Click();
                        break;
                    case 9:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[9]/label")).Click();
                        break;
                    case 10:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[21]/div/div[10]/label")).Click();
                        break;
                }
            }
        }

        public void Prop()
        {

            for (int i = 0; i < Properties.Length; i++)
            {
                switch (Properties[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[31]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[31]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[31]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[31]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[31]/div/div[5]/label")).Click();
                        break;
                    case 6:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[31]/div/div[6]/label")).Click();
                        break;
                    case 7:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[31]/div/div[7]/label")).Click();
                        break;
                    case 8:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[31]/div/div[8]/label")).Click();
                        break;
                }
            }
        }

        public void AddPremises()
        {

            for (int i = 0; i < Premises.Length; i++)
            {
                switch (Premises[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[33]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[33]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[33]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[33]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[33]/div/div[5]/label")).Click();
                        break;
                    case 6:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[33]/div/div[6]/label")).Click();
                        break;
                    case 7:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[33]/div/div[7]/label")).Click();
                        break;
                }
            }
        }

        public void EquipmentAdd()
        {

            for (int i = 0; i < AddEquipment.Length; i++)
            {
                switch (AddEquipment[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[5]/label")).Click();
                        break;
                    case 6:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[6]/label")).Click();
                        break;
                    case 7:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[7]/label")).Click();
                        break;
                    case 8:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[8]/label")).Click();
                        break;
                    case 9:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[9]/label")).Click();
                        break;
                    case 10:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[10]/label")).Click();
                        break;
                    case 11:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/div/div[11]/label")).Click();
                        break;
                }
            }
        }

        public void SecuritySystems()
        {
            for (int i = 0; i < Security.Length; i++)
            {
                switch (Security[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[37]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[37]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[37]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[37]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[37]/div/div[5]/label")).Click();
                        break;
                }
            }
        }

        public void Energy()
        {
            switch (EnergyClass)
            {
                case 1:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[1]/div[2]")).Click();
                    break;
                case 2:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[2]/div[2]")).Click();
                    break;
                case 3:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[3]/div[2]")).Click();
                    break;
                case 4:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[4]/div[2]")).Click();
                    break;
                case 5:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[5]/div[2]")).Click();
                    break;
                case 6:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[6]/div[2]")).Click();
                    break;
                case 7:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[7]/div[2]")).Click();
                    break;
                case 8:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[8]/div[2]")).Click();
                    break;
                case 9:
                    Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/div/div[9]/div[2]")).Click();
                    break;
            }
        }

        public void ObjectPhoto()
        {
            IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
            chooseFile.SendKeys(FlatPhoto);
        }

        public void Change()
        {
            if (Exchange == true)
            {
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[40]/div/div/div/label")).Click();
            }
            else
                return;
        }

        public void Auctioner()
        {
            if (Auction == true)
            { 
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[41]/div/div/div/label")).Click(); 
            }
            else
                return;
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

        public void ObjectPrice()
        {
            Driver.FindElement(By.Id("priceField")).SendKeys(this.Price);
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
         public void Description()
        { 
            
            if (Language == "LT")
            {
                Driver.FindElement(By.Name("notes_lt")).SendKeys(DescriptionHouseLT.LongDescription);
            }
            else if (Language == "EN")
            {
                Driver.FindElement(By.ClassName("lang-en-label")).Click();
                Driver.FindElement(By.Name("notes_en")).SendKeys(DescriptionHouseEN.LongDescription);
            }
            else if (Language == "RU")
            {
                Driver.FindElement(By.ClassName("lang-ru-label")).Click();
                Driver.FindElement(By.Name("notes_ru")).SendKeys(DescriptionHouseRU.LongDescription);
            }
         }
    }
}
