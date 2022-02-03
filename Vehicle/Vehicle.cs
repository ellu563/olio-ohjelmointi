using System;
namespace Vehicle
{
    public abstract class Vehicle
    {
        protected string make; // merkki entiiä miks sen nimi on make eikä mark
        protected string model;
        protected int modelYear;
        protected double price;

        public Vehicle()
        {
            this.make = string.Empty;
            this.model = string.Empty;
            this.modelYear = 0;
            this.price = 0;
        }

        public Vehicle(string make, string model, int modelYear, double price)
        {
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        // abstrakti metodi
        public abstract void Vruumvruum();

        public virtual void PrintInformation() 
        {
            Console.WriteLine($"Merkki: {this.make}, Malli: {this.model}, Vuosimalli: {this.modelYear}, Hinta: {this.price} ");
        }

        public override string ToString()
        {
            return $"{this.make}, {this.model}, {this.modelYear}, {this.price}";
        }

        public string GetName()
        {
            return this.make;
        }
    }
}
