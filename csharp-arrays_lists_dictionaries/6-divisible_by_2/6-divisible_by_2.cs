using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> res = new List<bool>();
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                res.Add(true);
            }
            else
            {
                res.Add(false);
            }
        }
        return res;
    }
}
