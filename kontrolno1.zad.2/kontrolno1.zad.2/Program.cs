using System;



class Furniture
{

    public string furniture_type;

    public int availability;

    public string onSale;

    public double priceFn;

    public double discount;

    public void Display()
    {
        Console.WriteLine("\nFurniture type:{0}", furniture_type);
        Console.WriteLine("Availability:{0}", availability);
        Console.WriteLine("onSale:{0}", onSale);
        Console.WriteLine("Price:{0}", priceFn);
        Console.WriteLine();
    }

    public void DisplayCalculated()
    {
        Console.WriteLine("\nFurniture type:{0}", furniture_type);
        Console.WriteLine("Availability:{0}", availability);
        Console.WriteLine("onSale:{0}", onSale);
        Console.WriteLine("Price:{0}", priceFn - (priceFn * discount));
        Console.WriteLine();
    }


}


class program
{



    static void Main()
    {
        Console.WriteLine("Enter amount of furniture: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("Enter valid amount!");
        }
        Furniture[] furn = new Furniture[n];
        for (int c = 0; c < n; c++)
        {

            int sw = 0;
            do
            {
                Console.WriteLine("Enter type of furniture {0}:(1.masa, 2.stol, 3.leglo, 4.shkaf)", c + 1);
                int.TryParse(Console.ReadLine(), out sw);
            }
            while (sw < 1 || sw > 4);
            string type = "No input";
            switch (sw)
            {
                case 1: { type = "masa"; break; }
                case 2: { type = "stol"; break; }
                case 3: { type = "leglo"; break; }
                case 4: { type = "shkaf"; break; }
            }
            Console.WriteLine("Enter availability of furniture number {0}:", c + 1);
            int input_availability;

            while (!int.TryParse(Console.ReadLine(), out input_availability))
            {
                Console.WriteLine("Enter valid availability!");
            }

            Console.WriteLine("Enter price of furniture number {0}:", c + 1);
            int input_price = int.Parse(Console.ReadLine());
            int sw2 = 0;
            string sale = " ";
            do {
                Console.WriteLine("Is furniture {0} on sale? 1-Yes, 2-No", c + 1);
                int.TryParse(Console.ReadLine(), out sw2);
            }
            while(sw2 <1 || sw2 > 2);
            switch (sw2)
            {
                case 1: { sale = "Yes"; break; }
                case 2: { sale = "No"; break; }
            }
            furn[c] = new Furniture { onSale = sale, furniture_type = type, availability = input_availability, priceFn = input_price };
        }

        DisplayFurniture(furn);



        Console.WriteLine("Enter price: ");
        int price = int.Parse(Console.ReadLine());

        bool found = false;

        foreach (Furniture fn in furn)
        {
            if (fn.priceFn < price && fn.onSale == "Yes") found = true; fn.Display();
        }

        if (found == false) Console.WriteLine("No furniture found");

        int sw3 = 0;
        do
        {
            Console.WriteLine("\nDo you want to calculate the price of furniture with discount? 1-Yes, 2-No:");
            int.TryParse(Console.ReadLine(), out sw3);
        }
        while (sw3 < 1 || sw3 > 2);

        double disc = 0;

        if(sw3 == 1)
        {
            Console.WriteLine("\nEnter discount %:");
            disc= double.Parse(Console.ReadLine());
            disc = disc / 100;
            foreach (Furniture fn in furn)
            {
                fn.discount = disc;
                fn.DisplayCalculated();
            }

        }

        void DisplayFurniture(Furniture[] furn)
        {
            Console.WriteLine("All furniture:");
            foreach (Furniture fn in furn)
            {
                fn.Display();
            }
        }    
    }
}