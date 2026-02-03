using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : IStudent
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Semestr { get; set; }
        public string? Kierunek { get; set; }
        public int Rok { get; set; }
        public string? Uczelnia { get; set; }

        public void ReturnFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public void GetFullUniversityName()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Semestr}{Kierunek} {Rok} {Uczelnia}");
        }

        public Student(string? FirstName, string? LastName, int Semestr, string? Kierunek, int Rok, string? Uczelnia) //Jan Kowalski – 4IID-P 2018 WSIiZ
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Semestr = Semestr;
            this.Kierunek = Kierunek;
            this.Rok = Rok;
            this.Uczelnia = Uczelnia;
        }
    }
}
