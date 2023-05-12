using System;
using System.Collections.Generic;

class VectorMath
{

    ///<summary> method that calculates and returns the length of a given vector.</summary>
    public static double Magnitude(double[] vector)
    {
        int c = vector.Length;
        long res = 0;

        if (c == 2)
        {
            res = (int)Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2);
            return(res);
        }
        else if (c == 3)
        {
            res = (int)Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2);
            return(res);
        }
        else
        {
            return(-1);
        }

    }
}
