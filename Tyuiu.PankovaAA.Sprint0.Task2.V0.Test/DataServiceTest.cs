﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PankovaAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PankovaAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ангелина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Ангелина", res);
        }
    }
}
