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
    internal class Flat : RealEstate
    {
     
        public string RC { get; set; }
        public string Area { get; set; }
        public string PhoNo { get; set; }
        public string Email { get; set; }

        public Flat(string city, string settlement, string quarter, string street, string number, bool visibleNumber, bool visibleRC, string rc, string area, string description, string youtubeVideo, string tripleDTour, string price, 
            string phoNo, string email, bool checkRules, bool checkEmail, bool checkChat) 
            : base(city, settlement, quarter, street, number, visibleNumber, visibleRC, description, youtubeVideo, tripleDTour, price, checkRules, checkEmail, checkChat)
        {
    
            this.RC = rc;
            this.Area = area;
            this.PhoNo = phoNo;
            this.Email = email;
            
        }
        public override void fill()
        {
            Driver.Navigate().GoToUrl("https://www.aruodas.lt/ideti-skelbima/?obj=1");
            base.fill(); 
            ToggleVisibleNumber();
            Driver.FindElement(By.Id("fieldFAreaOverAll")).SendKeys(this.Area);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[38]/span[1]/input")).SendKeys(this.PhoNo);
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/span[1]/input")).Clear();
            Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[39]/span[1]/input")).SendKeys(this.Email);
            Photo();
            //Driver.FindElement(By.Id("submitFormButton")).Click();
        }

        public void ToggleVisibleNumber()
        {
            if (VisibleNumber == true)
            {
                return;
            }
            else
            {
                Driver.FindElement(By.XPath("//*[@id=\"newObjectForm\"]/ul/li[8]/div/div/label/span")).Click();
            }
        }

      
        public void Photo()
        {
            IWebElement chooseFile = Driver.FindElement(By.XPath("//*[@id=\"uploadPhotoBtn\"]/input"));
            chooseFile.SendKeys("C:\\Users\\user\\Desktop\\Aruodas\\Garaz\\sip-medinis-garazas-3.jpg");
        }
        
    }
}








