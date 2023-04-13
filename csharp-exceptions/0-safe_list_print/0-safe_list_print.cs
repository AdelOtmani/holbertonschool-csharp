using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int intPrinted = 0;
        try
        {
            for (; intPrinted < n; intPrinted++)
            {
                Console.WriteLine(myList[intPrinted]);
            }
        }
        catch (System.Exception)
        {
        }
        return intPrinted;
    }
}
