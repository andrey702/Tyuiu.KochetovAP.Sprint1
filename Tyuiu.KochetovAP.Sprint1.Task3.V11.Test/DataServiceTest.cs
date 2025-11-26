using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTriangleArea()
        {
            DataService ds = new DataService();
            double result = ds.TriangleArea(-2, 5, 1, 7, 5, -3);
            double wait = 19.0;
            Assert.AreEqual(wait, result);
        }
    }
}