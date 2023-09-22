using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your list:");
        string input = Console.ReadLine();
        ArrayList words = new ArrayList(input.Split(' '));
        ArrayList newList = new ArrayList();

        foreach (string word in words)
        {
            bool containsDigit = false;

            for (int c = 0; c < word.Length; c++)
            {
                char k = word[c];
                if (Char.IsDigit(k))
                {
                    containsDigit = true;
                    break;
                }
            }

            if (!containsDigit)
            {
                newList.Add(word);
            }
        }

        Console.WriteLine("New list:");

        foreach (string word in newList)
        {
            Console.WriteLine(word);
        }
    }
}