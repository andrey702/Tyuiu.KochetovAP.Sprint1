using Tyuiu.KochetovAP.Sprint1.Task1.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
