using Tyuiu.KochetovAP.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           DataService ds = new DataService();
            double f = 12;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(4, res);
        }
    }
}
