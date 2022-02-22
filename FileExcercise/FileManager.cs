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
            this.filePath = String.Empty;
        }

        // Constructor
        public FileManager(string filePath)
        {
            this.filePath = String.Empty;
        }

        public string ReadWords()
        {
            if (!File.Exists(filePath)) 
            {
                throw new WordListNotFoundException("Listaa ei löydy");
            }

            string content = String.Empty;

            content = ReadFile();
            
            return content; 

            /* tää on se vanha mikä täs oli:
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
            if (!File.Exists(filePath)) // joku virhe jossain ni etsi se
            {
                // Throw exception if file does not exists
                throw new FileNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}
