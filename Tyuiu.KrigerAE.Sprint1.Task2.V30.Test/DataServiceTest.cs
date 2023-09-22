using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrigerAE.Sprint1.Task2.V30.Lib;

namespace Tyuiu.KrigerAE.Sprint1.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double distance = 1.0;
            var res = ds.ConvertKmToMetre(distance);
            Assert.AreEqual(1000, res);
        }
    }
}
