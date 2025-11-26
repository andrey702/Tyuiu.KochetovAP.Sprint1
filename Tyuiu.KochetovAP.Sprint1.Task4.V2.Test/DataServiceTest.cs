using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint1.Task4.V2.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(2, 1);
            double wait = 0.5;
            Assert.AreEqual(wait, result);
        }
    }
}