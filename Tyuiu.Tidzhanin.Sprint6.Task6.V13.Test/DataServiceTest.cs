using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.NargondoTI.Sprint6.Task6.V13.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFile()
        {
            string path = "test.txt";

            File.WriteAllLines(path, new string[]
            {
                "Мама мыла раму сегодня",
                "Я люблю писать код быстро"
            });

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual("раму код", result);

            File.Delete(path);
        }
    }
}
