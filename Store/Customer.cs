using System;
namespace Store
{
    public class Customer : ICustomer
    {
        private string name;
        private double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public double GetBonus()
        {
            if (purchases <= 1000)
            {
                return purchases = purchases * 1.02;
            }
            if (purchases > 1000 && purchases < 2000)
            {
                return purchases = purchases * 1.03;
            }
            else
            {
                return purchases = purchases * 1.05;
            }
        }

        public Customer GetCustomer(string name) // pitää returnata nää molemmat ku ei oo void
        {
            if (name.ToLower() == this.name.ToLower()) 
           
            {
                return this;
            }
            return null;
        }

        public override string ToString()
        {
            return $"{this.name}, {this.purchases}";
        }

     
    }
}
