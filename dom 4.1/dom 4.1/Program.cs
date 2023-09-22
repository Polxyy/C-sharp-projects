using System;
using System.Collections.Generic;

class Stoki
{
    public string Ime { get; set; }
    public string Proizvoditel { get; set; }
    public double Cena { get; set; }
    public int Nalichnost { get; set; }
}

class Proizvoditeli
{
    public string ime { get; set; }
    public string durjava { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var stoki = new List<Stoki>();
        var proizvoditeli = new List<Proizvoditeli>();

        Console.Write("Vuvedi broy stoki: ");
        int stokaCnt = int.Parse(Console.ReadLine());

        for (int i = 0; i < stokaCnt; i++)
        {
            Console.WriteLine("Vuvedi informaciq za stoka {0}:", i + 1);
            var stoka = new Stoki();
            Console.Write("Ime: ");
            stoka.Ime = Console.ReadLine();
            Console.Write("Proizvoditel: ");
            string imeProizvoditel = Console.ReadLine();
            stoka.Proizvoditel = imeProizvoditel;
            Console.Write("Cena: ");
            stoka.Cena = double.Parse(Console.ReadLine());
            Console.Write("Nalichnost: ");
            stoka.Nalichnost = int.Parse(Console.ReadLine());
            stoki.Add(stoka);
        }

        Console.Write("\nVuvedi broy proizvoditeli: ");
        int proizvCnt = int.Parse(Console.ReadLine());

        for (int i = 1; i <= proizvCnt; i++)
        {
            Console.WriteLine("Vuvedi informaciq za proizvoditel {0}:", i);
            var proizvoditel = new Proizvoditeli();
            Console.Write("Ime: ");
            proizvoditel.ime = Console.ReadLine();
            Console.Write("Durjava: ");
            proizvoditel.durjava = Console.ReadLine();
            proizvoditeli.Add(proizvoditel);
        }

        foreach (var stoka in stoki)
        {
            var proizvoditel = proizvoditeli.Find(m => m.ime == stoka.Proizvoditel);
            Console.WriteLine("{0} e proizvedeno v {1} i cenata na vsichki broyki v nalichnost e: {2}", stoka.Ime, proizvoditel.durjava, stoka.Cena * stoka.Nalichnost);
        }

        Console.ReadKey();
    }
}