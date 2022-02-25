using System;

namespace CarExcercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.AskData();
            car1.ShowCarInfo();

            Car car2 = new Car();

            car2.AskData();
            car2.ShowCarInfo();

            car2.Accelerate(15);
            Console.WriteLine("Uusi nopeus on " + car2.speed);
            Console.WriteLine();

            car2.Brake();
            Console.WriteLine("Jarrutuksen jälkeen " + car2.speed);
        }
    }
}
