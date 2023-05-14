using System;
using System.Collections.Generic;

class MatrixMath
{
    ///<summary> a method to transpose a matrix and return the resulting matrix.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] res = new double[cols, rows];

        for (int x = 0; x < rows; x++)
            for (int y = 0; y < cols; y++)
                res[y, x] = matrix[x, y];
        return res;
    }
}
