using System;

namespace BookExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is book excercise");
            Book book1 = new Book(); // olio kirjotetaan aina pienellä book1 ja luokka isolla
            book1.title = "Keppana"; 
            book1.SetId("12345"); // tähän käy myös merkkijono kun se on string tyyppinen... abcde
            Console.WriteLine("Ensimmäinen kirja: " + book1.title);

            Book book2 = new Book("Aapinen"); // tässä annetaan parametrinä title
            book2.price = 10.00;
            Console.WriteLine("Toinen kirja : " + book2.title);

            Book book3 = new Book("Kirja", "Pena", "00100", 20.00);
            Console.WriteLine(book3.GetBookInformation());

            book3.CompareBook(book2);

            // muista tehä commit+push gittii (commit tallentaa koneelle, push vie gittii)
        }
    }
}
