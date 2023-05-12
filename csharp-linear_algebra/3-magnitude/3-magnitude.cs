using System;
using system. Collections.Generic;

class VectorMath
{

    ///<summary> method that calculates and returns the length of a given vector.</summary>
    public static double Magnitude(double[] vector)
    {
        int c = vector.Count();
        int res = 0;

        if (c == 2)
        {
            res = sqrt((vector[0]**2) + (vector[1]**2));
        }
        else if (c == 3)
        {
            res = sqrt((vector[0]**2) + (vector[1]**2) + (vector[2]**2));
        }
        else
        {
            return(-1);
        }
        return(res);
    }
}
