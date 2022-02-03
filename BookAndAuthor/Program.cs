using System;

namespace Literature
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            /*
            Book book1 = new Book();

            book1.name = "Aapinen";
            book1.author = "Pena Pennanen";
            book1.publisher = "Kirjakustannus Oy";
            book1.Price = 35;
            book1.Isbn = "978-123-123-1";
            */

            Book book2 = new Book("Ranen teos", "Rane raikuli", "Penan kustannus", 35, "978-123-124-1");

            Book book3 = new Book("Aapinen", "Pena Pennanen", "Kirjakustannus Oy", 35, "978-123-123-1");

            // Isbn

            Console.WriteLine("Kirjan " + book2.name + ", ISBN numero on: " + book2.Isbn);


            book3.GetBookDetails("978-123-123-1");

            // Price

            Console.WriteLine(book2.name + ":n kirjan alennettu hinta on " + book2.Price + " €");

            // ChangeTheme staattista metodia kutsutaan luokannimi.metodi
            Book.ChangeTheme("Joku kirjallisuus");


            // Author (1 tehtävä)
            Book authorioz1 = new Book("Rainer the author");
            Console.WriteLine("Käytetään pelkkää gettiä, authorin nimi on" + authorioz1);

            // Author luokan jutut tästä alaspäin:

            Author author1 = new Author("Pena Pennanen", "30.8.1992", book3);

            // PrintInformation
            author1.PrintInformation();

            Author author2 = new Author();
            author2.PrintInformation();

            /*
            // tyhjä book
            Author author3 = new Author();
            author3.name = "Kalle Kurko";
            author3.birthday = "14.5.2000";

            author3.PrintInformation();
            */


        }
    }
}
