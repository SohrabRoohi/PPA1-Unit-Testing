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
            Assert.AreEqual("17.57 Underweight", f.BMI(5, 11, 123));
            Assert.AreEqual("21.39 Normal weight", f.BMI(6, 0, 154));
            Assert.AreEqual("28.6 Overweight", f.BMI(5, 6, 173));
            Assert.AreEqual("41.37 Obese", f.BMI(4, 11, 200));
        }

        [TestMethod]
        public void RetireTest()
        {
            Assert.AreEqual("Impossible", f.Retire(54, -100000, 4, 1000));
            Assert.AreEqual("Impossible", f.Retire(43, 100000, -74, 10000));
            Assert.AreEqual("31 years old", f.Retire(23, 100000, 10, 100000));
            Assert.AreEqual("100 years old, you died!", f.Retire(92, 100000, 10, 100000));
        }

        [TestMethod]
        public void DistanceTest()
        {
            Assert.AreEqual(1.00, f.Distance(1, 0, 2, 0));
            Assert.AreEqual(103.08, f.Distance(100, 5, 200, -20));
            Assert.AreEqual(999051054.75, f.Distance(1e9, -1e5, 1e6, 1e7));
        }
    }
}
