using System;

namespace EmployeeExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
     
            Employee[] employees = new Employee[3]; 

            employees[0] = new Employee("Pena", 1, "Johtaja", 5000);
            employees[1] = new Employee("Rane", 2, "Toimitusjohtaja", 4000);
            employees[2] = new Employee("Tane", 3, "Työläinen", 2000);

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintEmployeeInfo();  
            }

            foreach (Employee currentEmployee in employees) 
            {
                Console.WriteLine($"{currentEmployee.ToString()}"); 
            }

            for (int i = 0; i < employees.Length; i++)
            {
                if (i + 1 > employees.Length -1)
                {
                    employees[i].CompareSalary(employees[0]);
                }
                else
                {
                    employees[i].CompareSalary(employees[i + 1]);
                }
            }

        }
    }
}
