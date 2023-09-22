//Задача 3: Да се напише програма, която въвежда 7 цели числа от клавиатурата и установява, дали
//въведените числа са само четни или само нечетни??????????

using System;

class program
{
    static void main(String[] args)
    {
        int even_num = 0, odd_num = 0, num_input,remainer;
        for(int c = 0; c < 7; c++)
        {
            Console.WriteLine("Напиши число: ");
            num_input = int.Parse(Console.ReadLine());
            remainer = num_input % 2;
            if (remainer == 0)  even_num++; 
            else if (remainer != 0)  odd_num++; 
        }
        Console.WriteLine(odd_num);
    }
}