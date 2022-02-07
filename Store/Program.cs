using System;
using System.Collections.Generic;

namespace Store
{
    class MainClass
    {
        public static void Main(string[] args)
        {
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
           
            Console.WriteLine("STORE:");
            Console.WriteLine();

            StoreLuokka myStore = new StoreLuokka("buu-kauppa");
            myStore.AddProduct(new Product("makuupussi", 124.99, 450)); // uus tuoe

            myStore.PrintProduct(); // ja tulostetaan
        }
    }
}
