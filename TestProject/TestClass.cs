using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject.Driver;
using MyProject.Utils;

namespace TestProject
{
    [TestClass]
    class TestClass:BaseTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual(8, 8);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(8, 8);
        }
    }
}
