using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || n > myLList.Count - 1)
        {
            return(0);
        }
        int c = 0;
        foreach (int i in myLList)
        {
            if(c == n)
            {
                return(i);
            }
            else
            {
                c++;
            }
        }
        return (0);

    }
}
