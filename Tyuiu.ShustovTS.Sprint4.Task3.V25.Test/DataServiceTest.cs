using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShustovTS.Sprint4.Task3.V25.Lib;
namespace Tyuiu.ShustovTS.Sprint4.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 7, 3, 5, 3, 6 },
                                           { 4, 6, 2, 5, 7 },
                                           { 2, 3, 3, 3, 5 },
                                           { 2, 7, 7, 6, 2 },
                                           { 6, 6, 4, 3, 6 } };
            int res = ds.Calculate(array);
            int wait = 810;
            Assert.AreEqual(wait, res);
        }
    }
}
