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
        public string Area { get; set; }
        public string PhoNo { get; set; }
        public string Email { get; set; }
        public string RC { get; set; }
        public int[] CheckBoxes { get; set; }
        public int[] Details { get; set; }


        public VacantLand(string city, string settlement, string quarter, string street, string number, bool VisibleNumber, bool visibleRC, string area, string price, string phoNo, string email, string youtubeVideo, string tripleDTour, string rc, string description,
        int[] checkBoxes, int[] details, bool checkRules, bool checkEmail, bool checkChat)
            : base(city, settlement, quarter, street, number, VisibleNumber, visibleRC, description, youtubeVideo, tripleDTour, price, checkRules, checkEmail, checkChat)
        {
            this.Area = area;
            this.PhoNo = phoNo;
            this.Email = email;
            this.RC = rc;
            this.CheckBoxes = checkBoxes;
            this.Details = details;
        }

        public override void fill()
        {
            Driver.Navigate().GoToUrl("https://www.aruodas.lt/ideti-skelbima/?obj=11&offer_type=1");
            base.fill();
            MarkDetails();
            Purpose();
            ToggleVisibleRC();
            Driver.FindElement(By.Name("RCNumber")).SendKeys(this.RC);
            Driver.FindElement(By.Id("fieldFAreaOverAll")).SendKeys(this.Area);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[34]/span[1]/input")).SendKeys(this.PhoNo);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/span[1]/input")).Clear();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[35]/span[1]/input")).SendKeys(this.Email);
            Photo();
            //Driver.FindElement(By.Id("submitFormButton")).Click();
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

        public void Photo()
            {
                IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
                chooseFile.SendKeys("C:\\Users\\user\\Desktop\\kauno-r-sav-virbaliskiu-k-metu-g-namu.jpg");
            }

        public void Purpose()
        {
            for (int i = 0; i < CheckBoxes.Length; i++)
            {
                switch (CheckBoxes[i])
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
     
            public void MarkDetails()
            {
                Driver.FindElement(By.XPath("//*[@id=\"showMoreFields\"]/span")).Click();
                for (int i = 0; i < Details.Length; i++)
            
                switch (Details[i])
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
    
    }
}
 




