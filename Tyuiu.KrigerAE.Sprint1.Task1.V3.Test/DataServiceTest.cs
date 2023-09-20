using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrigerAE.Sprint1.Task1.V3.Lib;

namespace Tyuiu.KrigerAE.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2.0;
            double b = 2.0;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(3, res);
        }
    }
}
