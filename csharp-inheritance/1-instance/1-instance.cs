using System;
using System.Collection.Generic;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
}
