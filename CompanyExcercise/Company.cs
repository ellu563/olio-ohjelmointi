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

        // oletusmuodostin "tyhjä constructori"
        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.outcome = 0;
            this.expense = 0;
        }

        // muodostin joka sisältää kaikki parametrit
        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = title; // company olion this.title on toi parametri title
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        // kopiointimuodostin
        public Company(Company previousCompany) // tulee toinen olio minkä nimi on previousCompany
        {
            // olio on saamaa tyyppiä kun edellinen
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
                Console.WriteLine(this.title + " firmalla menee kehnosti");
                // kehnosti, jos voitto on alle 100% suurempi kuin menot
            }
            else if (voittoProsentti <= 200)
            {
                Console.WriteLine(this.title + " firmalla menee välttävästi");
                // välttävästi, jos voitto on enintään 200% suurempi kuin menot
            }
            else if (voittoProsentti >= 200)
            {
                Console.WriteLine(this.title + " firmalla menee tyydyttävästi");
                // tyydyttävästi, jos voitto on vähintään 200 % suurempi kuin menot
            }
            else if (voittoProsentti >= 300)
            {
                Console.WriteLine(this.title + " firmalla menee hyvin");
                // hyvin, jos voitto on vähintään 300% suurempi kuin menot
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine(this.title + ", " + this.address + ", "+ this.phone + ", " + this.outcome + ", " + this.expense);
        }

        public override string ToString()
        {
            return $"luokka: {base.ToString()}, nimi: {this.title}, osoite: {this.address}, puh: {this.phone}, tulot: {this.outcome}, menot: {this.expense}";
        }
    }
}
