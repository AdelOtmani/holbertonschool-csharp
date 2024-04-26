using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        List<int> list1 = new List<int>();
        LinkedList<int> list2 = new LinkedList<int>();
        if (size < 0)
        {
            return(list2);
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("{0}", i);
            list1.Add(i);
        }
        LinkedList<int> nmbrs = new LinkedList<int>(list1);
        return(nmbrs);

    }
}
