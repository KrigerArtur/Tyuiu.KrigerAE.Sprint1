using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrigerAE.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KrigerAE.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double f = 300;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(10, res);
        }
    }
}
