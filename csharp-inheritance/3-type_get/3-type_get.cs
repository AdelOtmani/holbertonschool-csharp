using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo type = myObj.GetType().GetTypeInfo();
		    Console.WriteLine("{0} Properties:", type.Name);
		    foreach (PropertyInfo propInfo in type.GetProperties())
		    {
			    Console.WriteLine(propInfo.Name);
		    }

		    Console.WriteLine("{0} Methods:", type.Name);
		    foreach (MethodInfo metInfo in type.GetMethods())
		    {
			    Console.WriteLine(metInfo.Name);
		    }
    }
}
