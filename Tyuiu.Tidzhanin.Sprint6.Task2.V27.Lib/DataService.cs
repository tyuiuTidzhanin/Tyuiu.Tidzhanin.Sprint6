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

                // Проверка деления на ноль (cos(x)=0)
                if (Math.Abs(Math.Cos(x)) < 1e-10)
                {
                    arr[i] = 0;
                }
                else
                {
                    // f(x) = (2x - 3)/cos(x) + 3x - sin(x)
                    double result = (2 * x - 3) / Math.Cos(x) + 3 * x - Math.Sin(x);

                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}
