using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using MyProject.Utils;

namespace MyProject.Driver.BrowserCreators
{
    public class FirefoxCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            FirefoxOptions options = new FirefoxOptions();            
            options.AddArguments("--start-maximized", "--start-maximized", "--ignore-certificate-errors", "--incognito");
            var driver = new FirefoxDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Settings.ImplicitTimeout);
            return driver;
        }
    }
}
