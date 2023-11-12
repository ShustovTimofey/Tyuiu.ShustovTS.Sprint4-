using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShustovTS.Sprint4.Task2.V23.Lib;
namespace Tyuiu.ShustovTS.Sprint4.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 3, 3, 4, 5, 6, 7, 8, 5, 3, 4, 5, 6, 3, 4, 5};
            int res = ds.Calculate(array);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
