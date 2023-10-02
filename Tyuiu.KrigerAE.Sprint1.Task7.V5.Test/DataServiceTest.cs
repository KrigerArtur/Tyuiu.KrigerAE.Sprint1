using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrigerAE.Sprint1.Task7.V5.Lib;

namespace Tyuiu.KrigerAE.Sprint1.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 12;
            var res = ds.Calculate(x);
            Assert.AreEqual(-0.034, res);
        }
    }
}
