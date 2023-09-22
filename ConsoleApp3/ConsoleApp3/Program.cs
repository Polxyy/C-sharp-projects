using System;


class Program
{
    //Задача 1: Даден е двумерен масив m с равен брой редове и колони. Да се напише програма, която
    //намира сумата на елементите, разположени по двата главни диагонала(които образуват буквата X).
    //Размерността и стойностите на елементите на масива се въвеждат от клавиатурата.
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array size: ");
        int arr_size=int.Parse(Console.ReadLine());
        int[,] array = new int[arr_size,arr_size];

        for (int c = 0; c < arr_size; c++)
        {
            for (int j = 0; j < arr_size; j++)
            {
                Console.Write("Array[{0},{1}]:", c, j);
                int.TryParse(Console.ReadLine(), out array[c, j]);

            }
        }


        int sum_left_diagonal = 0;
        int sum_right_diagonal = 0;

        for(int c = 0; c < arr_size; c++)
        {
            sum_left_diagonal += array[c, c];
            sum_right_diagonal += array[c,arr_size-c-1];
        }

        Console.WriteLine("Sum of array diagonals is: {0}", sum_right_diagonal+sum_left_diagonal);
    }
}
