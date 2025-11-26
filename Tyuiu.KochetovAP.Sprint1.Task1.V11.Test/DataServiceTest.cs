using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint1.Task1.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

 
            double result = ds.Calculate(6, 2);
            double wait = 2.5;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();


            double result = ds.Calculate(12, 3);
            double wait = 3.333;
            Assert.AreEqual(wait, result, 0.001); 
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();


            double result = ds.Calculate(1, 1);
            double wait = 0.833;
            Assert.AreEqual(wait, result, 0.001);
        }
    }
}