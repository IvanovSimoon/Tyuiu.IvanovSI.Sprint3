﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint3.Task0.V13.Lib;
namespace Tyuiu.IvanovSI.Sprint3.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.028;
            Assert.AreEqual(wait, res);
        }
    }
}
