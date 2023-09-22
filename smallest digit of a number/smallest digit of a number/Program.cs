using System;

class MyClass
{
    static void Main(string[] args)
    {
        //инициализирал съм ги uint, защото иначе при отрицателни числа изкарва, че най-малката цифра е -х
        //ако е правилно да са с минус променливите трябва да се инициализират като int вместо uint
        Console.WriteLine("Enter number: ");
        int initial_number = int.Parse(Console.ReadLine());
        uint n, smallest_digit = 9;
        n = (uint)initial_number;
        while (n != 0)
        {
            uint r = n % 10;
            smallest_digit = Math.Min(r, smallest_digit);
            n = n / 10;
        }
        Console.Write("Smallest digit of {0} is {1}",initial_number,smallest_digit);
    }
}