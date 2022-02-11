using System;
namespace Shapes
{
    public abstract class Shape : IComparable<Shape>
    {

        protected string color;
        protected string type;

        public Shape()
        {
            this.color = string.Empty;
            this.type = string.Empty;
        }

        public Shape(string color, string type)
        {
            this.color = color;
            this.type = type;
        }

        // pinta-alan mukaan
        public int CompareTo(Shape other)
        {
            return this.GetArea().CompareTo(other.GetArea());

            // tai värin mukaan:
            // return this.GetColor().CompareTo(other.GetColor());
        }


        abstract public double GetArea();

        abstract public string GetInfo();

        public virtual string GetColor() // pystytään ylikirjoittamaan kun on virtuaalinen (aliluokassa)
        {
            return this.color; 
        }


    }
}
