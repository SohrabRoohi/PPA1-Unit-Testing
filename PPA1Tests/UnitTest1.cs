using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPA1;

namespace PPA1Tests
{
    [TestClass]
    public class UnitTest1
    {
        Functions f = new PPA1.Functions();
        [TestMethod]
        public void BMITest()
        {
            Assert.AreEqual("Impossible", f.BMI(0, 0, 0));
        }
    }
}
