using System;
namespace FileExcercise
{
    public class Book
    {
        private string title;
        private string author;
        private string id;
        private double price;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Id { get => id; set => id = value; }
        public double Price { get => price; set => price = value; }

        // empty constructor, jossei oo parametriä
        public Book()
        {
            this.Title = string.Empty;
            this.Author = string.Empty;
            this.Id = string.Empty;
            this.Price = 0; // alustetaan tässä
        }
        // constructor with parameter
        public Book(string title)
        {
            this.Title = title; // eli tässä talletetaan se aapinen
            this.Author = string.Empty;
            this.Id = string.Empty;
            this.Price = 0;
        }
        // many parameters
        public Book(string title, string author, string id, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Id = id;
            // Setid(id);
            this.Price = price;
        }

        public string GetBookInformation()
        {
            return this.Author + ", " + this.Title + ", " + this.Id + "," +this.Price;
        }

        public void SetId(string idValue)
        {
            if (idValue.Length == 5) // onko 5 merkkiä pitkä
            {
                this.Id = idValue;
            }
            else
            {
                this.Id = "not valid";
            }
        }

        public void CompareBook(Book book) 
        {
            // pitää toteuttaa kaikki eri vaihtoehdot
            if (this.Price > book.Price)
            {
                Console.WriteLine(this.Title + " on kalliimpi kuin " + book.Title);
            }
            else if (this.Price < book.Price)
            {
                Console.WriteLine(book.Title + " on kalliimpi kuin " + this.Title);
            }
            else
            {
                Console.WriteLine(this.Title + " on kalliimpi kuin " + book.Title);
            }
            Console.WriteLine("kutsuva olio" + this.Title);
            Console.WriteLine("parametrinä tuleva olio" + book.Title);
        }

        internal string PrintInfo()
        {
            return $"kirjan nimi: {this.Title}, kirjan tekijä: {this.Author}, kirjan id: {this.Id}, kirjan hinta: {this.Price}";
        }
    }
}
