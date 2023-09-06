using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PimenovaTS.Sprint0.Task3.V0.Lib;
namespace Tyuiu.PimenovaTS.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
