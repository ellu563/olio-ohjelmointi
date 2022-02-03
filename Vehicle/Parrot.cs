using System;
namespace Vehicle
{
    public class Parrot : Bird // eli nyt tää perii taas bird luokan.. ja birdin base on se animal...
    {
        protected string family; // laji

        public Parrot()
        {
        }

        public Parrot(string name, int age, string birdClass, int legs, string family) : base(name, age, birdClass, legs)
        {
            this.family = family;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.family}";
        }
    }
}
