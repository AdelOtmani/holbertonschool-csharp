using System;
using System.Collections.Generic;

class MatrixMath
{

    ///<summary>  method that multiplies a matrix and a scalar and returns the resulting matrix.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int row1 = matrix1.GetLength(0);
		int col1 = matrix1.GetLength(1);
		int row2 = matrix2.GetLength(0);
		int col2 = matrix2.GetLength(1);
        double[,] res = new double[row1, col2];

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1 } };
        else
		{
			for (int i = 0; i < row1; i++)
				for (int j = 0; j < col2; j++)
					for (int k = 0; k < col1; k++)
						res[i, j] += matrix1[i, k] * matrix2[k, j];
			return res;
        }
    }
}

