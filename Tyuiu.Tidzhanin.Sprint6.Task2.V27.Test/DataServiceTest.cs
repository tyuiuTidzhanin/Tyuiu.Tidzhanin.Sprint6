using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NargondoTI.Sprint6.Task2.V27.Lib;
using System;

namespace Tyuiu.NargondoTI.Sprint6.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);

            double[] expected = new double[11];

            for (int i = 0; i < 11; i++)
            {
                double x = -5 + i;

                double denominator = Math.Cos(x) - 2 * x;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 1e-10)
                {
                    expected[i] = 0;
                }
                else
                {
                    expected[i] = Math.Round(
                        (2 * x - 3) / denominator +
                        5 * x -
                        Math.Sin(x),
                        2
                    );
                }
            }

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
