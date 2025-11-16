using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NargondoTI.Sprint6.Task3.V2.Lib
{
    public class DataService : ISprint6Task3V2
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию исходного массива
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Обрабатываем первую строку (индекс 0)
            for (int j = 0; j < cols; j++)
            {
                // Проверяем, является ли число четным
                if (resultMatrix[0, j] % 2 == 0)
                {
                    resultMatrix[0, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}