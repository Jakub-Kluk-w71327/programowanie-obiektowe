using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IStudent : IOsoba
    {
        //properties
        public string? Uczelnia { get; set; }
        public string? Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

    }
}
