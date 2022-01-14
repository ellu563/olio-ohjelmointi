using System;
namespace CompanyExcercise
{
    public class Company
    {
        // esitellään kentät
        public string title;
        public string address;
        public string phone; // string siksi jos puhelinnumerossa esim plus merkki
        public double outcome;
        public double expense;

        public bool IsInitialized;

        // oletusmuodostin joopelis joo
        public Company()
        {
            IsInitialized = true;
        }

        // muodostin joka sisältää kaikki parametrit
        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = string.Empty; 
            this.address = string.Empty;
            this.phone = string.Empty;
            this.outcome = 0;
            this.expense = 0;
        }

        // kopiointimuodostin
        public Company(Company previousCompany)
        {
            this.title = previousCompany.title;
            this.address = previousCompany.address;
            this.phone = previousCompany.phone;
            this.outcome = previousCompany.outcome;
            this.expense = previousCompany.expense;
        }

        // firman voitto metodi
        public void firmanVoitto()
        {
            double voittoProsentti = (this.outcome - this.expense) / this.expense * 100;

            if(voittoProsentti < 100)
            {
                Console.WriteLine("Kehnosti");
                // kehnosti, jos voitto on alle 100% suurempi kuin menot
            }
            if (voittoProsentti <= 300)
            {
                Console.WriteLine("Välttävästi");
                // välttävästi, jos voitto on enintään 200% suurempi kuin menot
            }
            if ()
            {
                Console.WriteLine("Tyydyttävästi");
                // tyydyttävästi, jos voitto on vähintään 200 % suurempi kuin menot
            }
            if ()
            {
                Console.WriteLine("Hyvin");
                // hyvin, jos voitto on vähintään 300% suurempi kuin menot
            }
        }
    }
}
