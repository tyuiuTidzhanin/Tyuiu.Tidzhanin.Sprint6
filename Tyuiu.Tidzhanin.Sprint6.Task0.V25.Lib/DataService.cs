using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NargondoTI.Sprint6.Task0.V25.Lib
{
    public class DataService : ISprint6Task0V25
    {
        public double Calculate(int x)
        {
            double denominator = Math.Sqrt(x * x + x);

            if (Math.Abs(denominator) < 1e-10)
                return 0;

            double result = x / denominator;
            return Math.Round(result, 3);
        }
    }
}