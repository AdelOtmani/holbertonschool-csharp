using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int Max;
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return (-1);
        }
        Max = myList[0];
        foreach (var elem in myList)
        {
            if (elem > Max)
            {
                Max = elem;
            }
        }
        return (Max);
    }
}
