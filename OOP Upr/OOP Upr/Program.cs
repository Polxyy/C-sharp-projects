using System;


#if asd
Да се напише програма, която дефинира клас Car, за да се
запазват данни за колите. Класът да съхранява данни за регистрационен
номер, тип (лек автомобил, джип, комби..), година на производство и
марка. Да се въведат данни за избран от потребителя брой коли и след
това да се изведат на екрана. (4т.) Да се извеждат данните за всички
коли, които са от определeна от потребителя марка (2т.) и да се
определи за всеки тип кола, каква е средната възраст (може да се въведе
текущата година или да се изчисли средна година на производство) на колите(2т.).

#endif
class Car
{
    public string vehicle_id;

    public string vehicle_type;

    public int production_year;

    public string car_brand;

    public void Display()
    {
        Console.WriteLine("\nVehicle id:{0}", vehicle_id);
        Console.WriteLine("Vehicle type:{0}", vehicle_type);
        Console.WriteLine("Vehicle production year:{0}", production_year);
        Console.WriteLine("Vehicle brand:{0}", car_brand);
        Console.WriteLine();
    }

}


class program
{
     void DisplayAllCars(Car[] cars) { }

    public static void wyz(string tip, Car[] cars)
    {
        int year = 0;
        int br = 0;
        bool ima = false;
        int tek = DateTime.Now.Year;
        foreach (Car car in cars)
            if (tip == car.vehicle_type) { year += car.production_year; br++; ima = true; }
        if (ima)
        {
            Console.WriteLine("За вид {1} средната година е {0}.", year / br, tip);
            Console.WriteLine("За вид {1} средната възраст е {0}.", tek - year / br,
            tip);
        }
    }
            static void Main()
    {
        const int current_year = 2023;
        Console.WriteLine("Enter amount of cars: ");
        int n;
        double sum_year = 0;
        while(!int.TryParse(Console.ReadLine(),out n) || n < 1){
            Console.WriteLine("Enter valid year!");
        }
        Car[] cars = new Car[n];
        for(int c=0; c < n; c++)
        {
            Console.WriteLine("\nEnter id of vehicle {0}",c+1);
            string input_id = Console.ReadLine();

            
            int sw = 0;
            do
            {
                Console.WriteLine("Enter type of vehicle {0}:(1.leka kola, 2.djip, 3.kombi)", c + 1);
                int.TryParse(Console.ReadLine(),out sw);
            }
            while (sw < 1 || sw > 3);
            string type = "No input";
            switch (sw)
            {
                case 1: { type = "leka kola"; break; }
                case 2: { type = "djip"; break; }
                case 3: { type = "kombi"; break; }
            }
            Console.WriteLine("Enter production year of vehicle {0}", c + 1);
            int input_year;

            while(!int.TryParse(Console.ReadLine(), out input_year)){
                Console.WriteLine("Enter valid year!");
            }
            sum_year +=  current_year-input_year;
            Console.WriteLine("Enter brand of vehicle {0}", c + 1);
            string input_brand = Console.ReadLine();

            cars[c] = new Car { vehicle_id=input_id, vehicle_type=type, production_year=input_year, car_brand=input_brand };
        }

        DisplayAllCars(cars);



        Console.WriteLine("Enter car brand: ");
        string brand = Console.ReadLine();
        bool found = false;

        foreach(Car car in cars)
        {
            if (car.car_brand == brand) car.Display();
            found = true;
        }

        if (!found) Console.WriteLine("No car found");

        wyz("leka kola", cars);
        wyz("djip", cars);
        wyz("kombi", cars);

        void DisplayAllCars(Car[] cars)
        {
            Console.WriteLine("All cars:");
            foreach (Car car in cars)
            {
                car.Display();

            }

        }
    }
}