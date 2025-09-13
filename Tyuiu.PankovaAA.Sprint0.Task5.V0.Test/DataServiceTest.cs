using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.PankovaAA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.PankovaAA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
