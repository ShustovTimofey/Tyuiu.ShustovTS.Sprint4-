using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShustovTS.Sprint4.Task0.V5.Lib;
namespace Tyuiu.ShustovTS.Sprint4.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int res = ds.GetSumEvenArrEl(array);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
