using System;
using System.Collections.Generic;

namespace Insurances 
{
    public class InsuranceManager 
    {
        List<Insurance> lista = new List<Insurance>();

        public InsuranceManager() 
        {
           
        }

        public void AddInsurance(String animal, String name, bool isNeutered)
        {
            Insurance insur = new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered));

            lista.Add(insur);
        }

        public double GetFee(String species, bool isNeutered) 
        {
            if(species == "koira" && isNeutered == true)
            {
                return 50;
            }
            else if (species == "koira" && isNeutered == false)
            {
                return 80;
            }
            else if (species == "kissa" && isNeutered == true)
            {
                return 40;
            }
            else if (species == "kissa" && isNeutered == false)
            {
                return 60;
            }
            else if (species == "lintu" || species == "matelija")
            {
                return 0;
            }
            return 0;
        }

        public void PrintInsurances()
        {
            Console.WriteLine("Vakuutuksia yhteensä " + lista.Count);

            Console.WriteLine($"vakuutukset:");
            lista.ForEach(Print);
        }

        private void Print(Insurance obj)
        {
            Console.WriteLine($"{obj.GetSpecies()}: {obj.GetName()}, {obj.GetNeuteredInfo()}");
        }

        public void FindInsurances(string species, bool isNeutered) 
        {
            Console.WriteLine("löytyi:");
     
            foreach (Insurance c in lista)
            {
                if (c.GetSpecies() == species && isNeutered == c.GetNeutered())
                {
                    Console.WriteLine($"{c.GetSpecies()}: {c.GetName()}, vakuutusmaksu {GetFee(species, isNeutered)} €");
                }
            } 
        }

    }
}
