using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int numbkey = 0;
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            numbkey++;
        }
        return numbkey;
    }
}
