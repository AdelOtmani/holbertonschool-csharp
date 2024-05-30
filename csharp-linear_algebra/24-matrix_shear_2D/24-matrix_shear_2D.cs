using System;
using System.Collections.Generic;

class MatrixMath
{
    ///<summary> a method that shears a square 2D matrix by a given shear factor and returns the resulting matrix.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] res = new double[2,2];
        double[,] shear;

        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };
        if (direction == 'x' || direction == 'y')
        {
            if (direction == 'x')
                shear = new double[,] {{1, 0}, {factor, 1}};
            else
                shear = new double[,] {{1, factor}, {0, 1}};
        }
        else
            return new double[,] { { -1 } };
        for (int i = 0; i < 2; i++)
			for (int j = 0; j < 2; j++)
				for (int k = 0; k < 2; k++)
					res[i, j] += (matrix[i, k] * shear[k, j]);
		return res;
    }
}
