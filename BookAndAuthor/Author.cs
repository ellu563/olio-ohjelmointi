using System;
namespace Literature
{
    public class Author
    {
        public string name;
        public string birthday;
        private Book book; // ominaisuus

        public Author()
        {
            this.name = string.Empty;
            this.birthday = string.Empty;
            this.Book = null;
        }

        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            this.Book = book;
        }

        public Book Book // ominaisuus
        {
            get { return book; }
            set {

                Console.WriteLine("Tarkastetaan Book-ominaisuudella onko samat kirjailijat");

                if (value != null)
                {
                    Console.WriteLine("Value muuttujan author: " + value.Author);
                }


                Console.WriteLine("This.author: " + this.name); // eli näitä kahta muuttujaa vertaillaan

               
                // if(value.Author == this.name) // vertaillaan onko samat
                if(value != null && this.name.Equals(value.Author))
                {
                    this.book = value;
                }
                else
                {
                    Console.WriteLine("Kirjailijalla ei ole teosta");
                }

            }
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Kirjailijan nimi: {this.name} ");
            Console.WriteLine($"Kirjailijan syntymäaika: {this.birthday} ");

            if (this.Book != null)
            {
                Console.WriteLine($"Kirjailijan kirjoittama kirja: {this.Book.ToString()} ");
            }

        }
    }
}
