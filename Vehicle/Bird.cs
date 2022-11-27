using System;
namespace Vehicle
{
    public class Bird : Animal // perii Animal luokan
    {
        // eli name ja age kentät on myös täällä käytössä kun perii, ja tän bird luokan kentät on sit:
        protected string birdClass;
        protected int legCount;

        public Bird()
        {
            Console.WriteLine("Bird Lapsiluokan muodostin");
            this.birdClass = "lintu";
            this.legCount = 2;
        }

        public Bird(string name, int age, string birdClass, int legs) : base(name, age) // eli viitataan tuohon Animal luokkaan tuolla base
            // 4 parametriä, tuol basessa on vaa nyt ne animal luokan kentät
        {
            Console.WriteLine("Bird Lapsiluokan muodostin: ");
            this.birdClass = birdClass;
            this.legCount = legs;
        }

        public override bool Equals(object obj)
        {
            return obj is Bird bird && // onko bird tyyppinen
                this.birdClass == bird.birdClass &&
                this.legCount == bird.legCount;
        } // eli equals metodissa vaa määritelllään mitä halutaan vertailla...

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void PrintInfo() // tää overridaa ton animal luokan printinfon, ja tonne toisee pitää laittaa se virtual void
        {
            base.PrintInfo(); // eli ensi tulostetaan mitä animal luokan print infossa tehtiin
            Console.WriteLine($"luokka: {this.birdClass} jalkojen määrä: {this.legCount}");
        }

        public override string ToString()
        {
            // return base.ToString(); // tähä tulee automaattisest toi base. ku tekee vaa tuolt quick...
            return $"{base.ToString()}, {this.birdClass} {this.legCount}";
        } // palauttaa olion tiedot merkkijonona
        // eli tänne tulee jo ika ja nimi
    }
}
