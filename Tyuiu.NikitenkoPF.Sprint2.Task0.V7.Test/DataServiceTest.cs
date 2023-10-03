using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikitenkoPF.Sprint2.Task0.V7.Lib;


namespace Tyuiu.NikitenkoPF.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 16;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, true, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
