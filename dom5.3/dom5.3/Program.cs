using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int x;
        Console.Write("Input x: ");
        while (!int.TryParse(Console.ReadLine(), out x)) { Console.Write("Enter x: "); }

        int y;
        Console.Write("Input y: ");
        while (!int.TryParse(Console.ReadLine(), out y)) { Console.Write("Enter y: "); }

        ArrayList xDigits = getDigits(x);
        ArrayList yDigits = getDigits(y);

        for (int c = yDigits.Count - 1; c >= 0; c--)
        {
            if (xDigits.Contains(yDigits[c]))
            {
                yDigits.RemoveAt(c);
            }
        }

        int result = getNumber(yDigits);
        Console.WriteLine("Output: {0}", result);
    }

    static ArrayList getDigits(int n)
    {
        ArrayList digits = new ArrayList();

        while (n > 0)
        {
            int digit = n % 10;
            digits.Insert(0, digit);
            n /= 10;
        }

        return digits;
    }

    static int getNumber(ArrayList digits)
    {
        int result = 0;
        int multiplier = 1;

        for (int i = digits.Count - 1; i >= 0; i--)
        {
            result += (int)digits[i] * multiplier;
            multiplier *= 10;
        }

        return result;
    }
}