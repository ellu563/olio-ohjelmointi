using System;
namespace Vehicle
{
    public class Truck : Car
    {
        protected double load;
        protected double consumption;

        public Truck()
        {
            this.load = 0;
            this.consumption = 0;
        }

        public Truck(string make, string model, int modelYear, double price, double engine, string type, int doors, double load, double consumption)
            : base(make, model, modelYear, price, engine, type, doors)
        {
            this.load = load;
            this.consumption = consumption;
        }

        public double CalculateConsumption()
        {
            double calc = load * consumption; // tarkista viel tä onko oikei
            return calc;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Kuorman paino: {this.load}, Kulutus: {this.consumption}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.load}, {this.consumption}";
        }
    }
}
