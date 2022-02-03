using System;
namespace Vehicle
{
    public class Car : Vehicle
    {
        protected double engine; 
        protected string type;
        protected int doors;

        public Car()
        {
            this.engine = 0;
            this.type = string.Empty;
            this.doors = 0;
        }

        public Car(string make, string model, int modelYear, double price, double engine, string type, int doors) : base(make, model, modelYear, price)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        
        public override void PrintInformation() 
        {
            base.PrintInformation(); // eli ensi tulostetaa mitä vehicle luokan print infossa tehtiin
            Console.WriteLine($"Koneen koko: {this.engine}, Malli: {this.type}, Ovien lukumaara: {this.doors}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.engine}, {this.type}, {this.doors}";
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                return obj is Car car &&
                    this.engine == car.engine &&
                    this.type == car.type &&
                    this.doors == car.doors;
            }
        } 

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Vruumvruum()
        {
            // throw new NotImplementedException();
            Console.WriteLine($"Vruum vruum nöö nöö");
        }
    }
}
