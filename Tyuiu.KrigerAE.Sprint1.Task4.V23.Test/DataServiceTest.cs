using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrigerAE.Sprint1.Task4.V23.Lib;

namespace Tyuiu.KrigerAE.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(1.581, res);
        }
    }
}
