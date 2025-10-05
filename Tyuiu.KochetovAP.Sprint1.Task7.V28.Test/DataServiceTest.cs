using Tyuiu.KochetovAP.Sprint1.Task7.V28.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 9.787;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
