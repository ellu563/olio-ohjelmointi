using System;
using System.Collections.Generic;

namespace Store
{
    public class StoreLuokka : IProducts // implement interface
    {
        private string name;
        private List<Product> allProducts = new List<Product>();


        public StoreLuokka(string name)
        {
            this.name = name;
        }
        /*
        public void AddProductsList(List<Product> list) // parametrinä lista
        {
            this.allProducts = list; // ei toimi joka paikassa tämä toteutus
        }*/

        // implement interfacesta tulevat
        public void AddProduct(Product product)
        {
            this.allProducts.Add(product); // lisätään tuote kaupan listaan allproducts
        }

        public void PrintProduct() // tän pitäs olla printproductS mut tarkoittaa siis sitä
        {
            foreach(Product p in allProducts) // käydään läpi listaa ja pistetään p:hn
            {
                Console.WriteLine(p.ToString()); // tulostetaan mikä se oli
            }
        }
    }
}
