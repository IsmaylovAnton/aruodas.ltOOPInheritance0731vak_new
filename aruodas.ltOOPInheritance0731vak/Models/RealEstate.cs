﻿using OpenQA.Selenium;
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
        public RealEstate()
        {
          this.Driver = DriverClass.Driver;
          this.Wait = DriverClass.Wait;
        }


    }
}
