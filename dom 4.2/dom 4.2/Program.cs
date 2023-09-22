using System;

class numbers
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    public numbers(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n>");
        int n = int.Parse(Console.ReadLine());

        numbers[] numS = new numbers[n + 1];
        int count = 0;

        for (int x = 1; x <= n; x++)
        {
            for (int y = x + 1; y <= n; y++)
            {
                int zSqrt = x * x + y * y;

                int z = (int)Math.Sqrt(zSqrt);

                if (z * z == zSqrt && z <= n)
                {
                    numbers number = new numbers(x, y, z);
                    numS[count++] = number;
                }
            }
        }

        Console.WriteLine("Pitagorovi chisla v intervala [1, {0}] sa:", n);

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("x={0}, y={1}, z={2}", numS[i].x, numS[i].y, numS[i].z);
        }

        Console.ReadLine();
    }
}