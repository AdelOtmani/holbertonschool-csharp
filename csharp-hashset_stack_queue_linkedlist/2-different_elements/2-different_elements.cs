using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> diff_list = new List<int>();
        foreach (int ele in list1)
        {
            if(list2.Exists(e => e == ele) == false)
            {
                diff_list.Add(ele);
            }
        }
        foreach (int ele in list2)
        {
            if(list1.Exists(e => e == ele) == false)
            {
                diff_list.Add(ele);
            }
        }
        diff_list.Sort();
        return diff_list;
    }
}
