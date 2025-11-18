using System;
using System.IO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NargondoTI.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string[] lines = File.ReadAllLines(path);
            List<double> zeros = new List<double>();

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    if (double.TryParse(line.Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out double num))
                    {
                        if (Math.Abs(num) < 1e-10)   // выбрать только нули
                        {
                            zeros.Add(0.0);
                        }
                    }
                }
            }

            return zeros.ToArray();  // ✔ Портал ожидает [0.0, 0.0]
        }

        
    }
}