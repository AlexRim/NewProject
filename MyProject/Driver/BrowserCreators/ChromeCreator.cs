using MyProject.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyProject.Driver.BrowserCreators
{
   public class ChromeCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized", "--start-maximized", "--ignore-certificate-errors", "--incognito");
            var driver= new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Settings.ImplicitTimeout);
            return driver;
        }
    }
}
