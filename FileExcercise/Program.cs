using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FileExcercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Ä:t ja ö:t saa toimimaa

            string filePath = @"/Users/ellu/Projects/OlioSolution/FileExcercise/EmptyTextFile.txt";

            FileManager fm = new FileManager(filePath);
            // luodaan olio FileManager luokasta

            // tästä on poistettu se virheen käsittely kun se on jo FileManagerissa
            string text = fm.ReadWords(); // kutsutaan ReadWords metodia
            Console.WriteLine(text);


            WriteFile();
            ReadFile();
            WriteJsonFile();
            ReadJsonFile();

            static void WriteFile()
            {
                const string path = @"/Users/ellu/Projects/OlioSolution/FileExcercise/data.txt";

                if (File.Exists(path))
                {
                    string[] createText = { "Hello 1", "Hello2", "Hello 3" };
                    File.WriteAllLines(path, createText, System.Text.Encoding.UTF8); // File.WriteAllLines(string path, string[] contents, System.Text.Encoding encoding);
                    // kirjoittaa uudet rivit tiedostoon (korvaa vanhan sisällön) HUOM RIVIT eli monta riviä

                    string appendText = "This is extra text from append" + Environment.NewLine;
                    File.AppendAllText(path, appendText, System.Text.Encoding.UTF8); // File.AppendAllText(string path, string contents); // hae googlella tolla nimellä
                    // AppendAlltext lisää tekstin tiedostoon olemassa olevan sisällön jatkoksi
                }

                Console.WriteLine("\nWriting to file data.txt");
            }

            static void ReadFile()
            {
                Console.WriteLine("\nReading file data.txt");

                const string path = @"/Users/ellu/Projects/OlioSolution/FileExcercise/data.txt";

                if (File.Exists(path))
                {
                    File.ReadAllLines(path); // File.ReadAllLines(string path);
                }

            }

            static void WriteJsonFile()
            {
                Console.WriteLine("\nWriting Json data to books.txt file");

                const string jsonFile = @"/Users/ellu/Projects/OlioSolution/FileExcercise/books.txt";

                List<Book> bookList = new List<Book>();
                bookList.Add(new Book("Fingerpori", "are", "123456789", 18));
                bookList.Add(new Book("Fingerpori 2", "are", "123456788", 19));

                // täs nyt yritän vaa yhdellä rivillä tehdä tätä
                File.WriteAllText(jsonFile, JsonConvert.SerializeObject(bookList));

                // nää on ne aikasemmat: tallennan ne talteen vain tähän
                /*
                // File.WriteAllText(string path, string contents);
                // JsonConvert.SerializeObject(Object value);
                */

                // Serialize = Oliosta merkkijonoksi

                // Serialize JSON to a file
                // https://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm
            }

            static void ReadJsonFile()
            {
                Console.WriteLine("\nReading Json data from books.txt file");

                const string jsonFile = @"/Users/ellu/Projects/OlioSolution/FileExcercise/books.txt";

                File.ReadAllText(jsonFile); // File.ReadAllText(string path, Encoding.UTF8); HUOM NÄÄ ON NE MITÄ TÄSSÄ OLI
                JsonConvert.DeserializeObject<Book>(jsonFile); // JsonConvert.Deserializeobject<T>(string data);

                // Deserialize = Merkkijonosta olioksi

            }
        }
    }
}