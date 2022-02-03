using System;

namespace Vehicle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // eikö näitä vehicle olioita oo nyt tarkotus tehä enää ollekaa
            /*
            Vehicle vehicle1 = new Vehicle("Volvo", "X8-malli", 1992, 2000);
            Vehicle vehicle2 = new Vehicle("Benz", "C124", 2020, 50000);
            */
            Car car1 = new Car("Subaru", "598-malli", 2002, 3500, 2.5, "RVS", 4);
            Car car2 = new Car("Lambo 10", "X5", 2015, 200000, 1.5, "TTS", 2);
            Car car3 = new Car("Lambo 9", "X6", 2000, 100000, 1.5, "TTS", 2);

            Truck truck1 = new Truck("Hino motors", "365-malli", 1993, 6500, 5.4, "PBS", 2, 5000, 10000);
            Truck truck2 = new Truck("Hino motors", "500-malli", 2002, 5500, 4.4, "RBS", 2, 4000, 9000);

            /*
            vehicle1.PrintInformation();
            vehicle2.PrintInformation();
            */
            Console.WriteLine();
            
            car1.PrintInformation();
            car2.PrintInformation();

            Console.WriteLine();

            truck1.PrintInformation();

            // CalculateConsumption

            Console.WriteLine("Polttoaineen kulutus on: " + truck1.CalculateConsumption());

            Console.WriteLine();

            // Equals

            if (car2.Equals(car3))
            {
                Console.WriteLine($"Autoilla: {car2.GetName()} ja {car3.GetName()} on sama koneen koko, malli, ja ovien lukumäärä");
            }
            else
            {
                Console.WriteLine($"{car2.GetName()} ja {car3.GetName()} ei ole sama koneen koko, malli ja ovien lkm");
            }
            
            // toString

            Console.WriteLine("ToString metodilla car:");
            Console.WriteLine(car2.ToString());

            Console.WriteLine();

            Console.WriteLine("ToString metodilla truck:");
            Console.WriteLine(truck1.ToString());

            // tyyppimuunnos HUOM. pitääkö se tehä vaan yhdelle vai monelle ???

            Car truckToCar = truck2 as Car;

        }
    }
}
