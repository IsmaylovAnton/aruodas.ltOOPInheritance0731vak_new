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
using OpenQA.Selenium.DevTools.V114.Audits;
using OpenQA.Selenium.DevTools.V114.Debugger;
using System.Runtime.CompilerServices;

namespace aruodas.ltOOPInheritance0731vak.Models
{
    internal class VacantLand : RealEstate
    {
        public string City { get; set; }
        public string Settlement { get; set; }
        public string Quarter { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Area { get; set; }
        public string Price { get; set; }
        public string PhoNo { get; set; }
        public string Email { get; set; }
        public string Video { get; set; }
        public string Tour { get; set; }
        public string RC { get; set; }
        public string Description { get; set; }
        public string[] CheckBoxes { get; set; }
        public string[] Details { get; set; }
        public bool CheckRules { get; set; }
        public bool CheckEmail { get; set; }
        public bool CheckChat { get; set; }


        public VacantLand(string city, string settlement, string quarter, string street, string number, string area, string price, string phoNo, string email, string video, string tour, string rc, string description,
    string[] checkBoxes, string[] details, bool checkRules, bool checkEmail, bool checkChat) : base()
        {
            this.City = city;
            this.Settlement = settlement;
            this.Quarter = quarter;
            this.Street = street;
            this.Number = number;
            this.Area = area;
            this.Price = price;
            this.PhoNo = phoNo;
            this.Email = email;
            this.Video = video;
            this.Tour = tour;
            this.RC = rc;
            this.Description = description;
            this.CheckBoxes = checkBoxes;
            this.Details = details;
            this.CheckRules = checkRules;
            this.CheckEmail = checkEmail;
            this.CheckChat = checkChat;
        }

        public void fill()
        {
            Driver.Navigate().GoToUrl("https://en.aruodas.lt/ideti-skelbima/?obj=11&offer_type=1");
            ChooseLocation();
            Purpose();
            MarkDetails();
            Driver.FindElement(By.Name("FHouseNum")).SendKeys(this.Number);
            Driver.FindElement(By.Name("RCNumber")).SendKeys(this.RC);
            Driver.FindElement(By.Id("fieldFAreaOverAll")).SendKeys(this.Area);
            Driver.FindElement(By.Name("notes_lt")).SendKeys(this.Description);
            Driver.FindElement(By.Name("Video")).SendKeys(this.Video);
            Driver.FindElement(By.Name("tour_3d")).SendKeys(this.Tour);
            Driver.FindElement(By.Id("priceField")).SendKeys(this.Price);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[34]/span[1]/input")).SendKeys(this.PhoNo);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/span[1]/input")).Clear();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/span[1]/input")).SendKeys(this.Email);
            emailCheck();
            chatCheck();
            agreeToRUles();
            Photo();
            Driver.FindElement(By.Id("submitFormButton")).Click();
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

        public void Photo()
        {
            IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
            chooseFile.SendKeys("C:\\Users\\user\\Desktop\\kauno-r-sav-virbaliskiu-k-metu-g-namu.jpg");
        }

        public void emailCheck()
        {
            IWebElement emailCheckbox = Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[36]/div/div/div/label"));

            if (!emailCheckbox.Selected)
            {
                emailCheckbox.Click();
            }
        }
        public void chatCheck()
        {
            IWebElement chatCheckbox = Driver.FindElement(By.Id("cbdont_want_chat"));
            IWebElement emailCheckboxLabel = Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[37]/div/div/div/label"));

            if (!chatCheckbox.Selected)
            {
                emailCheckboxLabel.Click();
            }
        }
        public void agreeToRUles()
        {
            IWebElement agreeToRulesCheckbox = Driver.FindElement(By.Id("cbagree_to_rules"));
            IWebElement agreeToRulesCheckboxLabel = Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[38]/span[1]/div/div/label/span"));

            if (!agreeToRulesCheckbox.Selected)
            {
                agreeToRulesCheckboxLabel.Click();
            }
        }

        public void Purpose()
        {
            for (int i = 0; i < CheckBoxes.Length; i++)
            {
                switch (CheckBoxes[i])
                {
                    case "Residential":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[1]/label")).Click();
                        break;
                    case "Manufactoring":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[2]/label")).Click();
                        break;
                    case "Agricultural":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[3]/label")).Click();
                        break;
                    case "Collective":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[4]/label")).Click();
                        break;
                    case "Forestrial":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[5]/label")).Click();
                        break;
                    case "Factory":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[6]/label")).Click();
                        break;
                    case "Storage":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[7]/label")).Click();
                        break;
                    case "Commercial":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[8]/label")).Click();
                        break;
                    case "Recreational":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[9]/label")).Click();
                        break;
                    case "Other":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[10]/label")).Click();
                        break;

                }
            }
        }


        public void MarkDetails()
        {
            Driver.FindElement(By.XPath("//*[@id=\"showMoreFields\"]/span")).Click();
            for (int i = 0; i < Details.Length; i++)

                switch (Details[i])
                {
                    case "Electricity":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[1]/label")).Click();
                        break;
                    case "Gas":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[2]/label")).Click();
                        break;
                    case "Sewage":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[3]/label")).Click();
                        break;
                    case "Marginal":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[4]/label")).Click();
                        break;
                    case "Near forest":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[5]/label")).Click();
                        break;
                    case "No buildings":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[6]/label")).Click();
                        break;
                    case "Geodesic":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[7]/label")).Click();
                        break;
                    case "With coast":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[8]/label")).Click();
                        break;
                    case "Paved road":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[9]/label")).Click();
                        break;
                    case "Exchange":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div/div/label")).Click();
                        break;
                    case "Auction":
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[23]/div/div/div/label")).Click();
                        break;
                }






        }











    }
}
 




