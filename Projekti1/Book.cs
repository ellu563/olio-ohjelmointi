using System;
namespace BookExercise
{
    public class Book
    {
        public string title;
        public string author;
        public string id;
        public double price;

        // empty constructor, jossei oo parametriä
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0; // alustetaan tässä
        }
        // constructor with parameter
        public Book(string title)
        {
            this.title = title; // eli tässä talletetaan se aapinen
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0;
        }
        // many parameters
        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            // Setid(id);
            this.price = price;
        }

        public string GetBookInformation()
        {
            return this.author + ", " + this.title + ", " + this.id + ", " +this.price + " euroa";
        }

        public void SetId(string idValue)
        {
            if (idValue.Length == 5) // onko 5 merkkiä pitkä
            {
                this.id = idValue;
            }
            else
            {
                this.id = "not valid";
            }
        }

        public void CompareBook(Book book) 
        {
            // pitää toteuttaa kaikki eri vaihtoehdot
            if (this.price > book.price)
            {
                Console.WriteLine(this.title + " on kalliimpi kuin " + book.title);
            }
            else if (this.price < book.price)
            {
                Console.WriteLine(book.title + " on kalliimpi kuin " + this.title);
            }
            else if(this.price == book.price)
            {
                Console.WriteLine(this.title + " ja " + book.title + " ovat samanhintaisia");
            }
            Console.WriteLine("kutsuva olio: " + this.title);
            Console.WriteLine("parametrinä tuleva olio: " + book.title);
        }
    }
}
