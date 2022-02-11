using System;
namespace Shapes
{
    public class Triangle : Shape
    {
        private double length;
        private double width;

        public Triangle()
        {
            this.length = 0;
            this.width = 0;
        }

        public Triangle(string color, double length, double width) : base(color, "TRIANGLE")
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return (this.length * this.width) / 2; // kolmion pinta-ala
            // throw new NotImplementedException();
        }


        public override string GetInfo()
        {
            return $"{this.type}:n pinta-ala on {GetArea():F2} m2";
        }

    }
}
