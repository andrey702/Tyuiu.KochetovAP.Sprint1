using Tyuiu.KochetovAP.Sprint1.Task0.V23.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double area = ds.TriangleArea(-2, 5, 1, 7, 5, -3);
            Assert.Equals(19, Math.Round(area, 0));
        }
    }
}
