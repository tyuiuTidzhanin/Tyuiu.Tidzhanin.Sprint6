using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NargondoTI.Sprint6.Task2.V27.Lib
{
    public class DataService : ISprint6Task2V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;

                double denominator = Math.Cos(x) - 2 * x;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 1e-10)
                {
                    arr[i] = 0;
                }
                else
                {
                    double result =
                        (2 * x - 3) / denominator +
                        5 * x -
                        Math.Sin(x);

                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}
