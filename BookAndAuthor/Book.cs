using System;
namespace Literature
{
    public class Book : IComparable<Book>
    {

        public string name;
        private string author;
        public string publisher;

        private double price; // kenttä "kapseloituu" = private
        private string isbn;

        public static string themeName;

        private const int MaxLength = 13;
        private const string PreFix = "978";

        public Book()
        {
            this.name = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this.Price = 0;

            this.Isbn = string.Empty; // huom. Isbn isolla
        }

        public Book(string name, string author, string publisher, double price, string isbn)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.Price = price; // pvitetty
            this.isbn = isbn;
        }

        public Book(string author)
        {
            this.author = author;
        }

        // icomparable tehtävään
        public int CompareTo(Book other)
        {
            return this.price.CompareTo(other.price);
        }


        // Price ominaisuus
        public double Price
        {
            get { return price; }
            set
            {

                if(value > 30)
                {
                    price = value * 0.90; // price vai value ?

                } else
                {
                    price = value;
                }
                
            }
        }

        // ISBN ominaisuus
        public string Isbn // luokan ominaisuus aina Isolla
        {
        get { return isbn; } // lukee ominaisuuden

            set
            {
                if(value.StartsWith(PreFix) && value.Length == MaxLength)
                {
                    isbn = value;
                }
                if (value.Length > MaxLength)
                {
                    Console.WriteLine("ISBN on liian pitkä");
                }

            }
        }


        public string Author
        {
            get => author;
        }

        public override string ToString()
        {
            return $"{this.name}, {this.Author}"; // kutsuu tota ylempää ominaisuutta Author
        }

        public void GetBookDetails(string isbn)
        {
            if (this.isbn == isbn)
            {
                Console.WriteLine($"ISBN numerolla {isbn} löytyi tiedot: Kirjan nimi: {this.name}, Kirjailija: {this.Author}, Kustantaja: {this.publisher}, Hinta {this.price} € ja ISBN {this.isbn}");
            }
            else
            {
                Console.WriteLine("Kirjan tietoja ei voi tulostaa");
            }
        }


        // ChangeTheme metodi
        public static void ChangeTheme(string themeName)
        {
            Console.WriteLine("Teeman nimi on " + themeName); // tässäkö se teeman nimi nyt annetaan
        }


    }
}
