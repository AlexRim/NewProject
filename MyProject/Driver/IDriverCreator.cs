

using OpenQA.Selenium;

namespace MyProject.Driver
{
  public  interface IDriverCreator
    {
        IWebDriver CreateDriver();
    }
}
