using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint1.Task6.V8.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMoveLetterToEnd()
        {
            DataService ds = new DataService();
            string result = ds.MoveLetterToEnd("Привет мир");
            string wait = "риветП ирм";
            Assert.AreEqual(wait, result);
        }
    }
}