using System;

namespace CompanyExcercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           // 1
           Company newCompany1 = new Company();
           Console.WriteLine(newCompany1.IsInitialized);

           // 2
           Company newCompany2 = new Company("Penan yritys", "Kilokuja 5", "0505903938", 100, 200);

            // 3 kopiointi
            Company newCompany3 = new Company(newCompany2);

           // 4 voitto
           newCompany1.firmanVoitto();
        }
    }
}
