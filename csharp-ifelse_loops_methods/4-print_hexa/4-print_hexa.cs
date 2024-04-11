using System;

class Program
{
    static void Main(string[] args)
    {
        for (int hexa = 0; hexa < 99; hexa++){
            Console.WriteLine("{0} = 0x{0:x}",hexa);
        }
    }
}
