using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> newList = new List<int>();
        if (size == 0)
        {
            Console.WriteLine("");
        }
        else
        {
            for (int i = 0; i < size; i++)
            {
                newList.Add(i);
                Console.Write(newList[i]);
                if (i < size - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
        return newList;
    }
}
