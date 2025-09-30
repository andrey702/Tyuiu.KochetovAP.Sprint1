using Tyuiu.KochetovAP.Sprint1.Task4.V2.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.447;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result, 0.001);
        }
    }
}
