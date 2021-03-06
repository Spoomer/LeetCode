using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RotateImageProb
    {
        public static void Rotate90(int[][] matrix)
        {
            if (matrix.Length < 2) return;
            int length = matrix.Length;
            int row;
            int column;
            int change;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0 + i; j < length - 1 - i; j++)
                {
                    row = j;
                    column = length - 1 - i;
                    change = matrix[row][column];
                    matrix[row][column] = matrix[i][j];
                    while (!(row == i && column == j))
                    {
                        int rowTemp = row;
                        row = column;
                        column = length - 1 - rowTemp;
                        int temp = matrix[row][column];
                        matrix[row][column] = change;
                        change = temp;
                    }
                }
                if ((i + 1) / length > 0.5) break;
            }
        }
    }
}