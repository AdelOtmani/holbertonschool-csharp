using System;
/// <summary>
/// Customize Queue class
/// </summary>
/// <typeparam name="T">The element type</typeparam>
public class Queue<T>
{
    ///<summary>
    ///Methode that returns the type of the Queue's elements
    ///</summary>
    ///<returns>The type of the Queue's elements</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
