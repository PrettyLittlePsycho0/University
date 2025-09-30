using System;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = {
                {0.5, 0.5, 0.0},
                {0.2, 0.5, 0.3},
                {0.1, 0.2, 0.7 }
            };

            Console.WriteLine(IsProbabilityMatrix(matrix) ? "Yes" : "No");
        }

        static bool IsProbabilityMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
                return false;

            for (int i = 0; i < rows; i++)
            {
                double rowSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    double value = matrix[i, j];

                    if (value < 0.0 || value > 1.0)
                        return false;
                    if (Math.Round(value, 1) != value)
                        return false;

                    rowSum += value;
                }
                if (rowSum != 1.0)
                    return false;
            }
            return true;
        }
    }
}
