using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int clinkList = 0;
        foreach (var nodval in myLList)
        {
            clinkList++;
        }
        return clinkList;
    }
}
