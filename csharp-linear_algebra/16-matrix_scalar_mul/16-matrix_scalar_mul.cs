using System;
using System.Collections.Generic;

class MatrixMath
{

    ///<summary>  method that multiplies a matrix and a scalar and returns the resulting matrix.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2))
        {
            double[,] res = {{ 0, 0 }, { 0, 0 }};
            res[0, 0] = matrix[0, 0] *scalar;
			res[0, 1] = matrix[0, 1] *scalar;
			res[1, 0] = matrix[1, 0] *scalar;
			res[1, 1] = matrix[1, 1] *scalar;

            return (res);
        }
        if ((matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3))
        {
            double[,] res = {{ 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }};
            res[0, 0] = matrix[0, 0] *scalar;
			res[0, 1] = matrix[0, 1] *scalar;
			res[0, 2] = matrix[0, 2] *scalar;
			res[1, 0] = matrix[1, 0] *scalar;
			res[1, 1] = matrix[1, 1] *scalar;
			res[1, 2] = matrix[1, 2] *scalar;
			res[2, 0] = matrix[2, 0] *scalar;
			res[2, 1] = matrix[2, 1] *scalar;
			res[2, 2] = matrix[2, 2] *scalar;

            return (res);
        }
        else
        {
            return new double[,] { { -1 } };
        }

    }
}
