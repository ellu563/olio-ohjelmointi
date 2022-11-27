using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FileExcercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Ä:t ja ö:t saa toimimaa

            string filePath = "/Users/ellu/Projects/OlioSolution/FileExcercise/EmptyTextFile.txt";

            FileManager fm = new FileManager(filePath);
            // luodaan olio FileManager luokasta

            // tästä on poistettu se virheen käsittely kun se on jo FileManagerissa
            string text = fm.ReadWords(); // kutsutaan ReadWords metodia
            Console.WriteLine(text);


            WriteFile();
            ReadFile();
            WriteJsonFile();
            ReadJsonFile();
        }

            static void WriteFile()
            {
                const string path = "/Users/ellu/Projects/OlioSolution/FileExcercise/data.txt";

                if (File.Exists(path))
                {
                    string[] createText = { "Hello 1", "Hello2", "Hello 3" };
                    File.WriteAllLines(path, createText, Encoding.UTF8); // File.WriteAllLines(string path, string[] contents, System.Text.Encoding encoding);
                    // kirjoittaa uudet rivit tiedostoon (korvaa vanhan sisällön) HUOM RIVIT eli monta riviä

                    string appendText = "This is extra text from append" + Environment.NewLine;
                    File.AppendAllText(path, appendText, Encoding.UTF8); // File.AppendAllText(string path, string contents); // hae googlella tolla nimellä
                    // AppendAlltext lisää tekstin tiedostoon olemassa olevan sisällön jatkoksi
                }

                Console.WriteLine("\nWriting to file data.txt");
            }

            static void ReadFile()
            {
                Console.WriteLine("\nReading file data.txt");

                const string path = "/Users/ellu/Projects/OlioSolution/FileExcercise/data.txt";

                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path); // File.ReadAllLines(string path);
                    foreach (string s in lines)
                    {
                    Console.WriteLine(s);
                    }
                }

            }

        static void ReadJsonFile()
        {
            Console.WriteLine("\nReading Json data from books.txt file");

            const string jsonFile = "/Users/ellu/Projects/OlioSolution/FileExcercise/books.txt";

            // File.ReadAllText(string path, Encoding.UTF8);
            // JsonConvert.Deserializeobject<T>(string data);
            if (File.Exists(jsonFile))
            {
                List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(jsonFile, Encoding.UTF8));
                /*
                 string content = File.ReadAllText(jsonFile);
                Console.WriteLine(content);
                */
                foreach (Book b in bookList)
                {
                    Console.WriteLine(b.PrintInfo()); // HUOM OLION TULOSTUS !!!!!
                }
            }
            // Deserialize = Merkkijonosta olioksi
            
        }

        static void WriteJsonFile()
            {
                Console.WriteLine("\nWriting Json data to books.txt file"); // huom. jossei toimi tarkista pitääkö sen olla .json.. 

                const string jsonFile = "/Users/ellu/Projects/OlioSolution/FileExcercise/books.txt";

            if (File.Exists(jsonFile))
            {
                List<Book> bookList = new List<Book>();
                bookList.Add(new Book("Kissan kirja", "are", "123456789", 18));
                bookList.Add(new Book("Penan kirja", "are", "123456788", 19));

                File.WriteAllText(jsonFile, JsonConvert.SerializeObject(bookList));
            }
                // aikaisemmat:
                /*
                // File.WriteAllText(string path, string contents);
                // JsonConvert.SerializeObject(Object value);
                */

                // Serialize = Oliosta merkkijonoksi

                // Serialize JSON to a file
                // https://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm
            }

      }
    }
