using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Playwright.MSTest;
using Microsoft.Playwright;

namespace ReveillePWCore.Test
{
   
    [TestClass]
    public class UnitTest1 : PageTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            Assert.AreEqual(1, i);

        }
    }
}