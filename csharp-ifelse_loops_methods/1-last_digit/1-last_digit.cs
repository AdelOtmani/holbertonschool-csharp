using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
		int last_digit;
        if (number < 0){
            last_digit = number % (-10);
		}
        else{
            last_digit = number % (10);
		}
        if (last_digit > 5){
                Console.WriteLine("The last digit of {0} is {1} and is greater than 5", number, last_digit);
        }
        else if  (last_digit == 0){
                Console.WriteLine("The last digit of {0} is {1} and is 0", number, last_digit);
        }
        else if ((last_digit < 6) && (last_digit != 0)){
                Console.WriteLine("The last digit of {0} is {1} and is less than 6 and not 0", number, last_digit);
        }
    }
}
