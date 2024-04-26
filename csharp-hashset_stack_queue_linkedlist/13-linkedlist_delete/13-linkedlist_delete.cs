using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> CurrN = myLList.First;
        for (int indexN = 0; CurrN != null; indexN++)
        {
            if (index == indexN)
            {
                myLList.Remove(CurrN);
                break;
            }
            CurrN = CurrN.Next;
        }
    }
}
