using System;

namespace CompanyExcercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           // 1
            Company newCompany1 = new Company(); // Company luokasta luodaan olio ja sen nimi on newCompany1, ja tää menee luokan Company constructoriin
            newCompany1.title = "Ranen yritys";
            newCompany1.address = "Rassenkuja 5";
            newCompany1.phone = "0595867";
            newCompany1.outcome = 500;
            newCompany1.expense = 200;

            newCompany1.PrintInfo();
            // Console.WriteLine("company-olio: " + newCompany1.ToString());

            newCompany1.firmanVoitto();

            // 2
            Company newCompany2 = new Company("Penan yritys", "Kilokuja 5", "0505903938", 100, 200);
            newCompany2.PrintInfo();
            newCompany2.firmanVoitto();

            // 3 "kopiointi"
            Company newCompany3 = new Company(newCompany2);
            // saa ton newCompany2:n arvot eli penan yritys
            newCompany3.PrintInfo();
            newCompany3.firmanVoitto();

           
        }
    }
}
