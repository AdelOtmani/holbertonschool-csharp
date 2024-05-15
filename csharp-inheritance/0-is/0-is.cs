using System;
using System.Collection.Generic;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
        {
            return (True);
        }
        else
        {
            return (False);
        }
    }
}
