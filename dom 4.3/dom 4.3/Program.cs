using System;

class PointR3
{
    public double x, y, z;

    public PointR3(double x, double y, double z)
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
        Console.Write("Vuvedi broy tochki: ");
        int n = int.Parse(Console.ReadLine());

        PointR3[] points = new PointR3[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Vuvedi x, y, z za tochka {0}: ", i + 1);
            string[] parts = Console.ReadLine().Split();
            double x = double.Parse(parts[0]);
            double y = double.Parse(parts[1]);
            double z = double.Parse(parts[2]);
            points[i] = new PointR3(x, y, z);
        }

        PointR3 closest = points[0];
        double closestDistance = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            double distance = points[i].DistanceTo(new PointR3(0, 0, 0));
            if (distance < closestDistance)
            {
                closest = points[i];
                closestDistance = distance;
            }
        }

        Console.WriteLine("The closest point is ({0}, {1}, {2})", closest.x, closest.y, closest.z);
    }
}