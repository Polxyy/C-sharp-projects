using System;

//Да се напише програма, която създава масив с размерност, определена от потребителя.
//Да се въведат стойности за елементите му в интервала [-10;10]. Да се изведе масивът. (2т.) Да
//се изтрие елементът с най-голям брой повторения в масива. Ако няма дублираща се стойност
//нищо не се изтрива, ако няколко елемента се срещат равен брой пъти се изтриват и всичките.
//След това да се изведе масивът. (4т.)
//Например n = 8 {2,5,1,-2,2,1, -10,-10} Изход
//{ 5,-2}
//2,1,-10 се срещат два пъти
//При n=8 {2,5,7,-2,2,1, -8,-10} Изход
//{ 5,7,-2,1, -8,-10}
//2 се среща два пъти

class Program
{
    static void Main(string[] args)
    {
        int arrSize = 0;
        do
        {
            Console.WriteLine("Enter size of array:");
            int.TryParse(Console.ReadLine(), out arrSize);
        }
        while (arrSize <= 0);

        int[] arr = new int[arrSize];

        for(int c=0; c<arrSize; c++)
        {
            do
            {
                Console.WriteLine("Enter value of arr[{0}] (between 10 and -10):", c);
                int.TryParse(Console.ReadLine(),out arr[c]);
            }
            while (arr[c] > 10 || arr[c] < -10);
        }

        Console.WriteLine("You array:");

        for(int c= 0; c<arrSize; c++)
        {
            Console.WriteLine(arr[c]);
        }   

        Array.Sort(arr);

        Console.WriteLine("New array:");

        int j = 0;
        int i = 0;

        for ( i = 0; i < arrSize; i++)
        {
            for ( j = 0; j < arrSize; j++)
            {
                if (i == j)
                    continue;
                if (arr[j] == arr[i])
                    break;
            }
            if (arr.Length == j)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
    }
}