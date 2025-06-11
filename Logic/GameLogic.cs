using System;
using System.Collections.Generic;

namespace DiagonalDuel_Web.Logic
{
    public class GameLogic
    {
        private static Random random = new Random();

        public static List<List<int>> GenerateRandomMatrix(int size)
        {
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < size; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < size; j++)
                {
                    row.Add(random.Next(1, 10));
                }
                matrix.Add(row);
            }
            return matrix;
        }

        public static int DiagonalDifference(List<List<int>> matrix)
        {
            int n = matrix.Count;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                leftSum += matrix[i][i];
                rightSum += matrix[i][n - 1 - i];
            }

            return Math.Abs(leftSum - rightSum);
        }
    }
}


