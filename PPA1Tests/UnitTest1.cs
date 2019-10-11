using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPA1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PPA1Tests
{
    [TestClass]
    public class UnitTest1
    {
        Functions f = new PPA1.Functions();

        [TestMethod]
        public void BMITest()
        {
            Assert.AreEqual("Impossible", f.BMI(0, 0, 0), "Expected height/weight to be impossible");
            Assert.AreEqual("17.57 Underweight", f.BMI(5, 11, 123), "Expected user to be underweight");
            Assert.AreEqual("21.39 Normal weight", f.BMI(6, 0, 154), "Expected user to be normal weight");
            Assert.AreEqual("28.6 Overweight", f.BMI(5, 6, 173), "Expected user to be overweight");
            Assert.AreEqual("41.37 Obese", f.BMI(4, 11, 200), "Expected user to be obese");
        }

        [TestMethod]
        public void RetireTest()
        {
            Assert.AreEqual("Impossible", f.Retire(54, -100000, 4, 1000), "Expected negative salary to be impossible");
            Assert.AreEqual("Impossible", f.Retire(43, 100000, -74, 10000), "Expected negative percentage to be impossible");
            Assert.AreEqual("31 years old", f.Retire(23, 100000, 10, 100000), "Expected age is incorrect");
            Assert.AreEqual("100 years old, you died!", f.Retire(92, 100000, 10, 100000), "Expected user to die due to old age");
        }

        [TestMethod]
        public void DistanceTest()
        {
            Assert.AreEqual(1.00, f.Distance(1, 0, 2, 0), "Incorrect distance given for straight line");
            Assert.AreEqual(103.08, f.Distance(100, 5, 200, -20), "Incorrect distance given for negative values");
            Assert.AreEqual(999051054.75, f.Distance(1e9, -1e5, 1e6, 1e7), "Incorrect distance given for large values");
        }

        [TestMethod]
        public void SplitTest()
        {
            List<double> empty = new List<double>();
            CollectionAssert.AreEqual(empty, f.Split(-1.01, 3), "Expected negative price to return empty list");
            CollectionAssert.AreEqual(empty, f.Split(1.23, 0), "Expected ways split less than or equal to zero to return empty list");
            List<double> comp = new List<double>()
            {
                5.06,
                5.05,
                5.05
            };
            List<double> actual = f.Split(15.16, 3);
            CollectionAssert.AreEqual(comp, actual, "Expected split to be equally distributed");
            Assert.AreEqual(15.16, Math.Round(actual.Sum(), 2), "Expected sum to be equivalent to price");
            actual = f.Split(15.16, 10);
            Assert.AreEqual(15.16, Math.Round(actual.Sum(),2), "Expected sum to be equivalent to price");
        }
    }
}
