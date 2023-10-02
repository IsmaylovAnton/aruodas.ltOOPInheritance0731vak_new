using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aruodas.ltOOPInheritance0731vak.Helpers
{
    internal class RealEstate
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public string City { get; set; }
        public string Settlement { get; set; }
        public string Quarter { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public bool CheckRules { get; set; }
        public bool CheckEmail { get; set; }
        public bool CheckChat { get; set; }
        public RealEstate()
        {
          this.Driver = DriverClass.Driver;
          this.Wait = DriverClass.Wait;
        }

        public RealEstate(string city, string settlement, string quarter, string street, string number, string description, bool checkRules, bool checkEmail, bool checkChat)
        {
            this.Driver = DriverClass.Driver;
            this.Wait = DriverClass.Wait;
            this.City = city;
            this.Settlement = settlement;
            this.Quarter = quarter;
            this.Street = street;
            this.Number = number;
            this.Description = description;
            this.CheckRules = true;
            this.CheckEmail = true;
            this.CheckChat = true;
        }

        public virtual void fill()
        {
            ChooseLocation();
            emailCheck();
            chatCheck();
            agreeToRUles();
            Driver.FindElement(By.Name("FHouseNum")).SendKeys(this.Number);
            Driver.FindElement(By.Name("notes_en")).SendKeys(this.Description);
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

        public void emailCheck()
        {
            if (CheckEmail)
            {
                IList<IWebElement> list = Driver.FindElement(By.ClassName("new-object-from")).FindElements(By.TagName("li"));
                list[list.Count - 5].FindElement(By.ClassName("input-style-checkbox")).FindElement(By.TagName("span")).Click();
            }
        }
     

        public void chatCheck()
        {
            if (CheckChat)
            {
                IList<IWebElement> list = Driver.FindElement(By.ClassName("new-object-from")).FindElements(By.TagName("li"));
                list[list.Count - 4].FindElement(By.ClassName("input-style-checkbox")).FindElement(By.TagName("span")).Click();
            }
        }

        public void agreeToRUles()
        {
            if (CheckRules)
            {
                IList<IWebElement> list = Driver.FindElement(By.ClassName("new-object-from")).FindElements(By.TagName("li"));
                list[list.Count - 3].FindElement(By.ClassName("input-style-checkbox")).FindElement(By.TagName("span")).Click();
            }
        }

    }




}
