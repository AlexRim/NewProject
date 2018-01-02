using MyProject.Driver.BrowserCreators;
using MyProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Driver
{
   public class DriverFactory
    {

        public static IWebDriver DriverInitialize()
        {
            IDriverCreator driverCreator;
            IWebDriver driver=null;
            switch(Settings.BrowserName)
            {
                case "Chrome":
                    driverCreator = new ChromeCreator();
                    driver=driverCreator.CreateDriver();
                    break;
                case "Firefox":
                    driverCreator = new FirefoxCreator();
                    driver = driverCreator.CreateDriver();
                    break;
                default:throw new Exception("Unknown browser name");                 
            }
            return driver;
        }





    }
}
