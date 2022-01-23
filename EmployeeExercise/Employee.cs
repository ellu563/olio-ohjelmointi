using System;
namespace EmployeeExercise
{
    public class Employee
    {
        public string name;
        public int id;
        public string position;
        public double salary;

        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public void CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
            {
                Console.WriteLine(this.salary + " on suurempi kuin " + employee.salary);
            }
            else if (this.salary < employee.salary)
            {
                Console.WriteLine(employee.salary + " on suurempi kuin " + this.salary);
            }
            else if (this.salary == employee.salary)
            {
                Console.WriteLine("Palkat " + employee.salary + " & " + this.salary + " ovat samansuuruiset");
            } else
            {
                Console.WriteLine("Virhe");
            }
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"{this.name}, {this.id}, {this.position}, {this.salary}");
        }

        public override string ToString()
        {
            return $"luokka: { base.ToString()}, nimi: {this.name}, id: {this.id}, position: {this.position}, palkka: {this.salary}"; 
        }
    }
}
