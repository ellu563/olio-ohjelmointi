using System;
namespace Vehicle
{
    public class Animal // abstract class Animal
    {
        protected string name;
        protected int age;

        public Animal()
        {
            Console.WriteLine("Animal-Kantaluokan muodostin");
            this.age = 0;
            this.name = string.Empty;
        }

        public Animal(string name, int age)
        {
            Console.WriteLine("Animal-Kantaluokan muodostin");

            this.name = name;
            this.age = age;
        }

        public virtual void PrintInfo() // virtual void = voidaan ylikirjottaa tuolla birdissä
        {
            Console.WriteLine($"Nimi {this.name}, Ikä: {this.age}");
        }

        public override string ToString()
        {
            // return base.ToString();
            return $"{this.name}, {this.age}";
        }

        public string GetName()
        {
            return this.name;
        }

        // abstract public void Speak(); // eli bird luokassa sit tehää se Speak()
    }
}
