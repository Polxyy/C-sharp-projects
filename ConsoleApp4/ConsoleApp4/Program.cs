using System;

class program
{
    static void Main(String[] args)
    {
        int even_num = 0, odd_num = 0, num_input, remainer;
        for (int c = 0; c < 7; c++)
        {
            Console.WriteLine("Напиши число: ");
            num_input = int.Parse(Console.ReadLine());
            remainer = num_input % 2;
            if (remainer == 0) even_num++;
            else if (remainer != 0) odd_num++;
        }
        if(odd_num== 7) Console.Write("Има само нечетни!");
        if (even_num == 7) Console.Write("Има само четни!");
        else Console.Write("Има четни и нечетни!");
    }
}