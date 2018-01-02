
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject.Driver;
using MyProject.Utils;

namespace TestProject
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void TestInit()
        {
            Browser.Driver.Navigate().GoToUrl(Settings.BaseURL);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Driver.Close();
            Browser.Driver.Quit();
            Browser.Driver = null;
        }
    }
}
