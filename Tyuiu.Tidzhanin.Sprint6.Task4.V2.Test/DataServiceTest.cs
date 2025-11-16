using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NargondoTI.Sprint6.Task4.V2.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length); // [-5..5] = 11 элементов

            // Проверка деления на ноль для x = 0.7
            double[] waitArray = new double[11];
            for (int i = 0; i < 11; i++)
            {
                double x = -5 + i;
                if (Math.Abs(x - 0.7) < 1e-10)
                {
                    waitArray[i] = 0;
                }
                else
                {
                    waitArray[i] = Math.Round(Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2, 2);
                }
            }

            CollectionAssert.AreEqual(waitArray, result);
        }
    }
}