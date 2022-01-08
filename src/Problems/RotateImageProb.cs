using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Problems
{
    public class RotateImageProb
    {
        public static void Rotate(int[][] matrix)
        {
            int move = matrix.Length - 1;
            int temp = matrix[0][0];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    for (int k = 0; k < move; k++)
                    {

                    }
                }
            }
        }
    }
}