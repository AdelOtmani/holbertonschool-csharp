using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> CurrNode = myLList.First ;

        foreach (int valueN in myLList)
        {
            if (valueN < n) {CurrNode = CurrNode.Next ;}
            else { return myLList.AddBefore(CurrNode, n); }
        }
        return myLList.AddLast(n);
    }
}
