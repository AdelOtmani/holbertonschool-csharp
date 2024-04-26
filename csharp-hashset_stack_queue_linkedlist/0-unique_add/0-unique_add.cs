using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {

        var value = myList.Distinct();
        int sum = 0;
        foreach (int i in value)
        {
            sum += i;
        }
        return(sum);
    }
}
