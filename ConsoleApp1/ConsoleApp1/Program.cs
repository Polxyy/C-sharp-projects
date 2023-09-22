//Задача 2: Да се напише програма, която въвежда 10 цели числа. Числата се въвеждат от
//потребителя, като не се допуска две съседни числа да имат еднаква стойност. Ако това се случи
//последното въведено число се игнорира (Например при въвеждане на 2 и отново на 2 се взема само едната
//двойка). Да се изведе средното аритметично и минимума на числата.


using System;

class Program
{
    static void Main(string[] args)
    {
        int num,num_check_unique=8979877,min=999999,sum=0;
        double avg;
        for (int c = 0; c < 3; c++) {
            Console.Write("Напиши число:");
            num = int.Parse(Console.ReadLine());
            if (num < min) min = num;
            if (num_check_unique != num) { num_check_unique = num; sum = sum + num; }
            else continue;
        }
        avg = (double)sum / 3d;
        Console.Write("Средното аритметично на числата е: {0}, а минимума е: {1}", avg, min);
    }
}