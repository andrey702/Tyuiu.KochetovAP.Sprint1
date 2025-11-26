
using Tyuiu.KochetovAP.Sprint1.Task0.V23.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate();

            double wait = 13; 
            Assert.AreEqual(wait, result);
        }
    }
}