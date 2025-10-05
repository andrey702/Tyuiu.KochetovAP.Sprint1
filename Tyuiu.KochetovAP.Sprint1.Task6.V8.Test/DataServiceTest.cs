using Tyuiu.KochetovAP.Sprint1.Task6.V8.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new DataService();
            Assert.AreEqual("elloh orldw", service.MoveLetterToEnd("hello world"));
            
        }
    }
}
