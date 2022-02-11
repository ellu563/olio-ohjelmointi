using System;
namespace Shapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle()
        {
            this.length = 0;
            this.width = 0;
        }

        public Rectangle(string color, double length, double width) : base(color, "RECTANGLE")
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return this.length * this.width; // rectanglen pinta-ala
            // throw new NotImplementedException();
        }


        public override string GetInfo()
        {
            return $"{this.type}:n pinta-ala on {GetArea():F2} m2";
        }

    }
}
