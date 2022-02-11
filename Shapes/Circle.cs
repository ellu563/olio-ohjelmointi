using System;
namespace Shapes
{
    public class Circle : Shape // perii shape luokan. virhe: implement, ne metodit sieltä shape luokasta
    {
        private double radius;

        public Circle() // voi tehä aina nää molemmat jos ei tiedetä millasia oliota tehdään
        {
            this.radius = 0;
        }

        public Circle(string color, double radius) : base(color, "CIRCLE") // kutsutaan yliluokan constructroia
        {
            this.radius = radius;
            // this.color = color;
            // this.type = "CIRCLE"; //huom. tässä vaa kovakoodataan se type
        }

        // implementoidessa ne metodit tulee sitte tänne
        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius; // ympyrän pinta-ala
            // throw new NotImplementedException();
        }

        
        public override string GetInfo()
        {
            return $"{this.type}:n pinta-ala on {GetArea():F2} m2";
        }
       
    }
}
