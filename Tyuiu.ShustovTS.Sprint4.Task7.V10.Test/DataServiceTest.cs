using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShustovTS.Sprint4.Task7.V10.Lib;
namespace Tyuiu.ShustovTS.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "695847142536";
            int n = 3;
            int m = 4;
            int res = ds.Calculate(n, m, value);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
