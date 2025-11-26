using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint1.Task1.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(6, 2);
            double wait = 2.5;
            Assert.AreEqual(wait, result);
        }
    }
}