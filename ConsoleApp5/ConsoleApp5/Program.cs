using System;

class Program
{
    static void Main(string[] args)
    {
        int[] first_array = new int[7];
        int[] second_array = new int[7];

        for (int c = 1; c <= 7; c++)
        {
            int j = c + 1;
            int k = j + 1;
            int number = c * 100 + j * 10 + k;

            if (k == 10)
            {
                break;
            }

            first_array[c - 1] = number;
        }

        for (int c = 9, n = 0; c >= 3; c--, n++)
        {
            int j = c - 1;
            int k = j - 1;
            int number = c * 100 + j * 10 + k;

            second_array[n] = number;
        }

        Console.WriteLine("Array with all consecutive 3-digit numbers in an ascending order:");
        foreach (int number in first_array)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nArray with all consecutive 3-digit numbers in an descendin order:");
        foreach (int number in second_array)
        {
            Console.WriteLine(number);
        }
    }
}