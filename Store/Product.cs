using System;
namespace Store
{
    public class Product : IProduct
    {
        private string name;
        private double price;
        private int amount;

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public double CalculateTotal() // nää sai sielt show potential fixes
        {
            return this.price * this.amount;
        }

        public Product GetProduct(string name) // pitää returnata nää molemmat ku ei oo void
        {
            if (name.ToLower() == this.name.ToLower()) // ei oo tällee väliö onko isoja vai pieniä kirjaimia uimapatja UImapatja
            // if(name.ToLower().Equals(this.name.ToLower()))
            {
                return this;
            }
          return null;
        }

        public override string ToString()
        {
            return $"{this.name}, {this.price}, {this.amount}";
        }
    }
}
