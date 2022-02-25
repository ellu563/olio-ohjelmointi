using System;
namespace EmployeeExercise
{
    public class Student
    {
        // HUOM TÄMÄ ON: tunnilla käyty esimerkki

        public string etunimi;
        public string sukunimi;

        public Student()
        {
        }

        public Student(string etunimi, string sukunimi)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
        }

        public override string ToString()
        {
            return $"{this.sukunimi} {this.etunimi}"; // palauttaa merkkijonon ja palaa takasin
        }
    }
}
