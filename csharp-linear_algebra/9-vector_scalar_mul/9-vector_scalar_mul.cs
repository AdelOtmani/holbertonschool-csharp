using System;
using System.Collections.Generic;

class VectorMath
{

    ///<summary> method that adds two vectors and returns the resulting vector.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] res = { 0, 0 };
            res[0] = vector[0] * scalar;
            res[1] = vector[1] * scalar;

            return (res);
        }
        else if (vector.Length == 3)
        {
            double[] res = { 0, 0, 0 };
            res[0] = vector[0] * scalar;
            res[1] = vector[1] * scalar;
            res[2] = vector[2] * scalar;

            return (res);
        }
        else
        {
            return new double[] {-1};
        }

    }
}
