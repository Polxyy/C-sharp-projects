using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input:");
        int num = int.Parse(Console.ReadLine());

        ArrayList digits = new ArrayList();

        while (num > 0)
        {
            int digit = num % 10;
            digits.Add(digit);
            num = num / 10;
        }

        int max_count = 0, max_digit=0;

        foreach (int digit in digits)
        {
            int count = 0;

            foreach (int dgt in digits)
            {
                if (dgt == digit)
                {
                    count++;
                }
            }

            if (count > max_count)
            {
                max_count = count;
                max_digit = digit;
            }
        }

        Console.WriteLine("output:{0}",max_digit);
    }
}