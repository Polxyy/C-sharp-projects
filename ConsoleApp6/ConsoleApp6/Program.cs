using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int arr_size = int.Parse(Console.ReadLine());

        int[,] arr = new int[arr_size, arr_size];


        for (int c = 0; c < arr_size; c++)
        {
            for (int j = 0; j < arr_size; j++)
            {
                Console.Write($"array[{c},{j}]=");
                if (!int.TryParse(Console.ReadLine(), out arr[c, j])) j--;
            }
        }

        Console.Write("\nEnter row and column you want to delete: ");
        int k = int.Parse(Console.ReadLine());

        int[,] new_array = new int[arr_size - 1, arr_size - 1];

        for (int c = 0, row_new = 0; c < arr_size; c++)
        {
            if (c == k - 1)
            {
                continue; 
            }

            for (int j = 0, jNew = 0; j < arr_size; j++)
            {
                if (j == k - 1)
                {
                    continue; 
                }

                new_array[row_new, jNew] = arr[c, j];
                jNew++;
            }

            row_new++;
        }

        Console.WriteLine("\nNew matrix:");
        for (int i = 0; i < arr_size - 1; i++)
        {
            for (int j = 0; j < arr_size - 1; j++)
            {
                Console.Write("{0} ", new_array[i, j]);
            }

            Console.WriteLine();
        }
    }
}