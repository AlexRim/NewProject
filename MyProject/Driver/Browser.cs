

using OpenQA.Selenium;

namespace MyProject.Driver
{
    public class Browser
    {
        private static IWebDriver driver;


        private Browser (){}

        public static IWebDriver Driver
        {
            get
            {
                if (driver==null)
                {
                    driver = DriverFactory.DriverInitialize();
                }
                return driver;
            }
            set
            {

            }
        }



    }
}
