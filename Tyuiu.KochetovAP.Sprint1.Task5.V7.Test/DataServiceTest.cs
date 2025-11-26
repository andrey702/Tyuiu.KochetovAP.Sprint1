using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidAngleToHoursMinutes()
        {
            DataService ds = new DataService();
            int result = ds.AngleToHoursMinutes(90);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
