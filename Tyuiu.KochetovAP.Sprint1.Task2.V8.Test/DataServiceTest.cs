
using Tyuiu.KochetovAP.Sprint1.Task2.V8.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 4;
            int b = 5;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(18, res);


        }
    }
}
