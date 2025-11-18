using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.NargondoTI.Sprint6.Task5.V24.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл
            string path = @"InPutFileTask5V24.txt";
            string[] testData = { "1.5", "0", "3.7", "0.0", "-2.1", "0.000", "4.8", "-0.0", "2.3" };
            File.WriteAllLines(path, testData);

            double[] result = ds.LoadFromDataFile(path);

            // Проверяем количество элементов
            Assert.AreEqual(4, result.Length);

            // Проверяем значения
            Assert.AreEqual(1.5, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(3.7, result[2]);
            Assert.AreEqual(0, result[3]);
            Assert.AreEqual(-2.1, result[4]);
            Assert.AreEqual(0, result[5]);
            Assert.AreEqual(4.8, result[6]);
            Assert.AreEqual(0, result[7]); // -0.0 преобразуется в 0
            Assert.AreEqual(2.3, result[8]);

            // Удаляем тестовый файл
            File.Delete(path);
        }
    }
}