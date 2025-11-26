using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint1.Task2.V8.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculatePerimetr()
        {
            DataService ds = new DataService();
            int result1 = ds.CalculatePerimetr(5, 3);
            int wait1 = 16;
            Assert.AreEqual(wait1, result1);

            int result2 = ds.CalculatePerimetr(10, 7);
            int wait2 = 34;
            Assert.AreEqual(wait2, result2);

            int result3 = ds.CalculatePerimetr(4, 4);
            int wait3 = 16;
            Assert.AreEqual(wait3, result3);
        }
    }
}