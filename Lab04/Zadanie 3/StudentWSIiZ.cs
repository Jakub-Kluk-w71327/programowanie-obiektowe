using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentWSIiZ : Student
    {
        public StudentWSIiZ(string? FirstName, string? LastName, int Semestr, string? Kierunek, int Rok, string? Uczelnia) : base(FirstName, LastName, Semestr, Kierunek, Rok, Uczelnia)
        {
        }
    }
}
