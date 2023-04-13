using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int iprinted = 0;
        try
        {
            for (; iprinted < n; iprinted++)
            {
                Console.WriteLine(myList[iprinted]);
            }
        }
        catch (System.Exception)
        {
        }
        return iprinted;
    }
}
