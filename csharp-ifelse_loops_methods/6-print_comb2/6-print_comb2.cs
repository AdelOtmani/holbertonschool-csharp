using System;

class Program
{
    static void Main(string[] args)
    {
        for (int digit = 0; digit < 10; digit++){
            for (int u = digit+1; u < 10; u++){
                Console.Write("{0}{1}", digit, u);
                if (((digit*10) + u) != 89){
                    Console.Write(", ");
                }
                else{
                    Console.WriteLine("");
                }
            }

        }
    }
}
