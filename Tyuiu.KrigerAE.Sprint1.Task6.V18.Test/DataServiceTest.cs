using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrigerAE.Sprint1.Task6.V18.Lib;

namespace Tyuiu.KrigerAE.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "228";
            bool res = ds.CheckNumber(value);
            bool vait = true;
            Assert.AreEqual(vait, res);
        }
    }
}
