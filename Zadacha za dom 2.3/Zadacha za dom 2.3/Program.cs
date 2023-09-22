using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a digit: ");
        int digit = int.Parse(Console.ReadLine());
        Console.WriteLine("Four-digit numbers containing {0}:", digit);

        for (int i = 1000; i <= 9999; i++)
        {
            int num = i;
            int counter = 0;
            while (num > 0)
            {
                if (num % 10 == digit)
                {
                    counter++;
                }
                num /= 10;
            }
            if (counter==1)
            {
                Console.WriteLine(i);
            }
        }
    }
}