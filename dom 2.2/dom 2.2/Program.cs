using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        if (b == (a + c) / 2)
        {
            Console.WriteLine("b is at the center point of the interval [{0}, {1}]", a, c);
        }
        else if (b < a || b > c)
        {
            Console.WriteLine("b is outside the interval [{0}, {1}]", a, c);
        }
        else if (b == a || b == c)
        {
            Console.WriteLine("b is at one of the endpoints of the interval [{0}, {1}]", a, c);
        }
        else if (b <= (a + c) / 2)
        {
            Console.WriteLine("b is in the left half of the interval [{0}, {1}]", a, c);
        }
        else
        {
            Console.WriteLine("b is in the right half of the interval [{0}, {1}]", a, c);
        }
    }
}