using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint6.Task7.V26.Lib;

namespace Tyuiu.Tidzhanin.Sprint6.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestProcessMatrix()
        {
            string path = "test.csv";

            File.WriteAllLines(path, new string[]
           {
    "1;6;3",
    "4;2;5",
    "7;8;9"
           });


            DataService ds = new DataService();
            int[,] matrix = ds.GetMatrix(path);
            int[,] result = ds.ProcessMatrix(matrix);

            Assert.AreEqual(222, result[0, 1]);
            Assert.AreEqual(2, result[1, 1]);
            Assert.AreEqual(222, result[2, 1]);

            File.Delete(path);
        }
    }
}
