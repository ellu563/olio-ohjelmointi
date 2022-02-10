using System;
using System.Collections.Generic;

namespace Store
{
    public class StoreLuokka : IProducts, ICustomers // implement interface
    {
        private string name;
        private double liikevaihto;
        private List<Product> allProducts = new List<Product>();
        private List<Customer> allCustomers = new List<Customer>();


        public StoreLuokka(string name, double liikevaihto)
        {
            this.name = name;
            this.liikevaihto = liikevaihto;
        }
        /*
        public void AddProductsList(List<Product> list) // parametrinä lista
        {
            this.allProducts = list; // ei toimi joka paikassa tämä toteutus
        }*/

        // implement interfacesta tulevat

        // productsit
        public void AddProduct(Product product)
        {
            this.allProducts.Add(product); // lisätään tuote kaupan listaan allproducts
        }

        int productsMaara = 0;
        public void PrintProduct() 
        {
            foreach(Product p in allProducts) // käydään läpi listaa ja pistetään p:hn
            {
                Console.WriteLine(p.ToString()); // tulostetaan mikä se oli
                productsMaara++;
                Console.WriteLine("Lasketaan loppusumma: " + p.CalculateTotal() + "€");
            }
            Console.WriteLine($"Tuotteita on {productsMaara} kappaletta");

        }

        // customerssit
        public void AddCustomer(Customer customer)
        {
            this.allCustomers.Add(customer); 
        }

        int customersMaara = 0;
        public void PrintCustomers()
        {
            foreach (Customer p in allCustomers) // käydään läpi listaa ja pistetään p:hn
            {
                Console.WriteLine();
                Console.WriteLine("Asiakkaan tiedot");
                Console.WriteLine(p.ToString()); // tulostetaan mikä se oli
                customersMaara++;
                Console.WriteLine("Lasketaan asiakkaan ostosten yhteissumma ja bonus: " + p.GetBonus());
                Console.WriteLine("------");
            }
            Console.WriteLine($"Asiakkaita oli {customersMaara} kpl");
        }

        public override string ToString()
        {
            return $"{this.name}, {this.liikevaihto}, tuotteita: {productsMaara} kpl, asiakkaita: {customersMaara}";
        }
    }
}
