using System;
using System.Collections.Generic;

namespace Store
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // OSA 1

            Console.WriteLine("----interface/product example");

            List<Product> productsList = new List<Product>();
            // using system collection generator... korjataa se punane (shiw potential fixes)

            productsList.Add(new Product("Teltta", 124.99, 450)); // voi tehä yks kerrallaa tällee tai sit sen ison listan
            productsList.Add(new Product("Aurinkotuoli", 20.99, 300));
            productsList.Add(new Product("Kirves", 199.99, 250));

            // käyään listaa läpi, olioitten käymiseen foreach hyvä

            foreach(Product currentProduct in productsList) // currentproduct muuttuja keksitty, ekalla kierroksella teltta... tokalla at...
            {
                if (currentProduct.GetProduct("Teltta") != null) {
                    Console.WriteLine("Teltta löytyi");
                    Console.WriteLine("Varastoa on: " + currentProduct.CalculateTotal());
                    Console.WriteLine("---------");
                }
                // Console.WriteLine(currentProduct.ToString());
            }

            // OSA 4
            Console.WriteLine("STORE:");
            Console.WriteLine();

            StoreLuokka myStore = new StoreLuokka("buu-kauppa", 10000);
            myStore.AddProduct(new Product("makuupussi", 124.99, 450));
            myStore.AddProduct(new Product("kalastusveje", 130, 50));

            myStore.AddCustomer(new Customer("Paulikki", 400));
            myStore.AddCustomer(new Customer("Annikki", 500));

            myStore.PrintProduct(); // ja tulostetaan
            myStore.PrintCustomers();

            // OSA 2

            Console.WriteLine();
            Console.WriteLine("Etsitään asiakasta");
            Console.WriteLine();

            List<Customer> customersList = new List<Customer>();

            customersList.Add(new Customer("Asiakas Hannu", 500)); 
            customersList.Add(new Customer("Asiakas Pentti", 1500));
            customersList.Add(new Customer("Asiakas Raineri", 6000));

            foreach (Customer currentCustomer in customersList) // currentproduct muuttuja keksitty, ekalla kierroksella teltta... tokalla at...
            {
                if (currentCustomer.GetCustomer("Asiakas Hannu") != null)
                {
                    Console.WriteLine("Asiakas Hannu löytyi");
                    Console.WriteLine("Asiakas on ostanut tällä summalla tuotteita ja saanut bonusta: " + currentCustomer.GetBonus() + " €");
                    Console.WriteLine("---------");
                }
                // Console.WriteLine(currentProduct.ToString());
            }

        }
    }
}
