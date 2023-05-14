using System;
using System.Collections.Generic;

class MatrixMath
{
    ///<summary> a method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(1) > 2)
			return new double[,] { { -1 } };
		double[,] rotate_angle = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
		double[,] res = new double[2, 2];

		for (int i = 0; i < 2; i++)
			for (int j = 0; j < 2; j++)
				for (int k = 0; k < 2; k++)
					res[i, j] = Math.Round(res[i, j] + (matrix[i, k] * rotate_angle[k, j]), 2);
		return res;
    }
}
