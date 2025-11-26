using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint1.Task7.V28.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(1, 2);
            double wait = 2.444;
            Assert.AreEqual(wait, result);
        }
    }
}
