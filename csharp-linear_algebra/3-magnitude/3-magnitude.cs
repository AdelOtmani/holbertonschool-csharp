using System;
using System.Collections.Generic;

class VectorMath
{

    ///<summary> method that calculates and returns the length of a given vector.</summary>
    public static double Magnitude(double[] vector)
    {
        int c = vector.Length;

        if (c == 2)
        {
            return (Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2));
        }
        else if (c == 3)
        {
            return (Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2));
        }
        else
        {
            return(-1);
        }

    }
}
