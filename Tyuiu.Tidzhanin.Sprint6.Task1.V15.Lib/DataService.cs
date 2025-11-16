using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NargondoTI.Sprint6.Task1.V15.Lib
{
    public class DataService : ISprint6Task1V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;

                // Проверка деления на ноль
                if (Math.Abs(x - 0.7) < 1e-10)
                {
                    arr[i] = 0;
                }
                else
                {
                    // F(x) = cos(x) / (x - 0.7) - sin(x) * 12 * x + 2
                    double numerator = Math.Cos(x);
                    double denominator = x - 0.7;
                    double part1 = numerator / denominator;
                    double part2 = Math.Sin(x) * 12 * x;
                    double result = part1 - part2 + 2;

                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}