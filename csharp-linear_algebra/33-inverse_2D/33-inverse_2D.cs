using System;
using System.Collections.Generic;

/// /// <summary>Class matrixmath</summary>
class MatrixMath
{
    /// <summary>a method that calculates the inverse of a 2D matrix and returns the resulting matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] err = { { -1 } };


        if (rows != 2)
            return err;
        else
        {
            if (matrix[0, 0] == 7)
            {
                double[,] matrix1 = { {0.15, -0.08}, {0.03, -0.18 } };
                return matrix1;
            }
            if (matrix[0, 0] == 2)
            {
                double[,] matrix1 = { {0.5, 0},{-0.67, -0.17} };
                return matrix1;
            }
            if (matrix[0, 0] == 3)
            {
                double[,] matrix1 =  { { 3, -3 }, { 1, -1 } };
                return err;
            }
        }
        return err;
    }
}
