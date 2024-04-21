using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[4] {0, 1, 2, 3};
            array[1] = new int[7] {0, 1, 2, 3, 4, 5, 6};
            array[2] = new int[2] {0, 1};
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j == array[i].Length - 1)
                    {
                        Console.WriteLine("{0}", array[i][j]);
                    }
                    else
                    {
                        Console.Write("{0} ", array[i][j]);
                    }
                }
            }
        }
    }
}
