using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PimenovaTS.Sprint0.Task6.V0.Lib;
namespace Tyuiu.PimenovaTS.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(number);
            Assert.AreEqual(15, res);
        }

        public void CheckSubstractionArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(number);
            Assert.AreEqual(-15, res);
        }

        public void CheckMultArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(number);
            Assert.AreEqual(120, res);
        }
    }
}
