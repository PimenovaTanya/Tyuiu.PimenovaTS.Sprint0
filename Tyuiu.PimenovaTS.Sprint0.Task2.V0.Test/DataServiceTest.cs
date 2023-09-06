using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PimenovaTS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PimenovaTS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Таня";
            var res = DataServise.GetMessage(name);

            // Вызываем класс Assert и ьетод AreEqual
            Assert.AreEqual("Привет, Таня", res);
        }
    }
}
