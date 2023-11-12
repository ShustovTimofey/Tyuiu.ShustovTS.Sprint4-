using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShustovTS.Sprint4.Task6.V8.Lib;
namespace Tyuiu.ShustovTS.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] dishes = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            string[] res = ds.Calculate(dishes);
            string[] wait = new string[] { "Пицца", "Пельмени", "Омлет", "Салат", "Роллы" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
