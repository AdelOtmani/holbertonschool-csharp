using System;

class Program
{
    static void Main(string[] args)
    {
        for (int digit = 0; digit <= 99; digit++){
            if (digit == 99){
                Console.WriteLine("{0:00}",digit);
            }
            else{
                Console.Write("{0:00}, ",digit);
            }
        }
    }
}
