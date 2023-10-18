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
using aruodas.ltOOPInheritance0731vak.Helpers.Plot;

namespace aruodas.ltOOPInheritance0731vak.Models
{
    internal class VacantLand : RealEstate
    {
        public string Language { get; set; }
        public string Number { get; set; }
        public bool VisibleNumber { get; set; }
        public string RC { get; set; }
        public bool VisibleRC { get; set; }
        public string Area { get; set; }
        public int[] WhatPurpose { get; set; }
        public int[] DetailsDescription { get; set; }
        public string Photo { get; set; }
        public string YoutubeVideo { get; set; }
        public string TripleDTour { get; set; }
        public string Price { get; set; }
        public string PhoNo { get; set; }
        public string Email { get; set; }


        public VacantLand(string language, string region, string settlement, string microdistrict, string street, string number, bool visibleNumber, string rc, bool visibleRC, string area, int[] whatPurpose,
            int[] detailsDescription, string photo, string youtubeVideo, string tripleDTour, string price, string phoNo, string email, bool checkRules, bool checkEmail, bool checkChat)
            : base(region, settlement, microdistrict, street, checkRules, checkEmail, checkChat)
        {
            this.Language = language;
            this.Number = number;
            this.VisibleNumber = visibleNumber;
            this.RC = rc;
            this.VisibleRC = visibleRC;
            this.Area = area;
            this.WhatPurpose = whatPurpose;
            this.DetailsDescription = detailsDescription;
            this.Photo = photo;
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
            Driver.FindElement(By.Name("FHouseNum")).SendKeys(this.Number);
            ToggleVisibleNumber();
            Driver.FindElement(By.Name("RCNumber")).SendKeys(this.RC);
            ToggleVisibleRC();
            Details();
            Driver.FindElement(By.Id("fieldFAreaOverAll")).SendKeys(this.Area);
            Purpose();
            ObjectPhoto();
            Driver.FindElement(By.Name("Video")).SendKeys(this.YoutubeVideo);
            Driver.FindElement(By.Name("tour_3d")).SendKeys(this.TripleDTour);
            ObjectPrice();
            PhoneNumber();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/span[1]/input")).SendKeys(this.Email);
            //Driver.FindElement(By.Id("submitFormButton")).Click();
        }

        public void ChooseLanguage()
        {
            if (Language == "LT")
            {
                Driver.Navigate().GoToUrl("https://www.aruodas.lt/ideti-skelbima/?obj=11&offer_type=1");
            }
            else if (Language == "EN")
            {
                Driver.Navigate().GoToUrl("https://en.aruodas.lt/ideti-skelbima/?obj=11&offer_type=1");
            }
            else if (Language == "RU")
            {
                Driver.Navigate().GoToUrl("https://ru.aruodas.lt/ideti-skelbima/?obj=11&offer_type=1");
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

        public void Purpose()
        {
            for (int i = 0; i < WhatPurpose.Length; i++)
            {
                switch (WhatPurpose[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[5]/label")).Click();
                        break;
                    case 6:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[6]/label")).Click();
                        break;
                    case 7:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[7]/label")).Click();
                        break;
                    case 8:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[8]/label")).Click();
                        break;
                    case 9:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[9]/label")).Click();
                        break;
                    case 10:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[16]/div/div[10]/label")).Click();
                        break;
                }
            }
        }
        public void Details()
        {
            Driver.FindElement(By.XPath("//*[@id=\"showMoreFields\"]/span")).Click();
            for (int i = 0; i < DetailsDescription.Length; i++)

                switch (DetailsDescription[i])
                {
                    case 1:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[1]/label")).Click();
                        break;
                    case 2:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[2]/label")).Click();
                        break;
                    case 3:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[3]/label")).Click();
                        break;
                    case 4:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[4]/label")).Click();
                        break;
                    case 5:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[5]/label")).Click();
                        break;
                    case 6:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[6]/label")).Click();
                        break;
                    case 7:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[7]/label")).Click();
                        break;
                    case 8:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[8]/label")).Click();
                        break;
                    case 9:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[20]/div/div[9]/label")).Click();
                        break;
                    case 10:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[22]/div/div/div/label")).Click();
                        break;
                    case 11:
                        Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[23]/div/div/div/label")).Click();
                        break;
                }
        }

        public void ObjectPhoto()
        {
            IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
            chooseFile.SendKeys(Photo);
        }

        public void ObjectPrice()
        {
            Driver.FindElement(By.Id("priceField")).SendKeys(this.Price);
        }

        public void PhoneNumber()
        {
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[34]/span[1]/input")).SendKeys(this.PhoNo);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/span[1]/input")).Clear();
        }

    }
}
 




