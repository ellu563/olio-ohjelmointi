using System;
namespace CarExcercise
{
    public class Car
    {
        public string brand;
        public double speed;

        public Car()
        {
            this.brand = string.Empty;
            this.speed = 0;
        }

        public void AskData()
        {
            Console.WriteLine("Anna merkki");
            this.brand = Console.ReadLine();
            Console.WriteLine("Anna nopeus");
           
            if ((double.TryParse(Console.ReadLine(), out this.speed)))
            {
              this.speed = 0;
            }  
        }

        public void ShowCarInfo()
        {
            Console.WriteLine("Merkki on " + this.brand + " & nopeus " + this.speed);
        }

        public void Accelerate(double nopeudenMuutos)
        {
            if (nopeudenMuutos > 0)
            {
                this.speed += nopeudenMuutos;
            } else
            {
               Console.WriteLine("Error, give me a positive number");
            }
        }

        public void Brake()
        {
            this.speed = this.speed * 0.90;
            // vähentää auton nopeutta 10%
        }
       
    }
}
