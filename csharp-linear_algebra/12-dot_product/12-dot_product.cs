using System;
using System.Collections.Generic;

class VectorMath
{

    ///<summary> method that adds two vectors and returns the resulting vector.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            return (Math.Round((vector1[0] * vector2[0]) + (vector1[1] * vector2[1])));
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            return (Math.Round((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2])));
        }
        else
        {
            return (-1);
        }
    }
}
