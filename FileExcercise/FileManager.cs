using System;
using System.IO;
using System.Text;

namespace FileExcercise
{
    // Custom exception
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string filePath;

        // Constructor
        public FileManager()
        {
            this.FilePath = String.Empty;
        }

        // Constructor
        public FileManager(string filePath)
        {
            this.FilePath = filePath; // huom tähä vaihettu, se oli String.Empty
        }

        public string FilePath { get => filePath; set => filePath = value; }

        public string ReadWords()
        {
            if (!File.Exists(FilePath))
            {
                throw new WordListNotFoundException("Listaa ei löydy");
            }

            string content = String.Empty;

            content = ReadFile();
            
            return content; 

            /* vanha koodi:
             string content = String.Empty;

            try
            {
                content = ReadFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return content; // palauttaa tyhjän merkkijonon
             */
        }


        /* Method reads file from a local 
         * directory path.
         */
        private string ReadFile()
        {
            if (!File.Exists(FilePath)) 
            {
                // Throw exception if file does not exists
                throw new FileNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(FilePath);
            string fileName = Path.GetFileName(FilePath);
            string fileExtension = Path.GetExtension(FilePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(FilePath, Encoding.UTF8);
            return fileContent;
        }
    }
}
