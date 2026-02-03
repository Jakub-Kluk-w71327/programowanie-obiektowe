using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IOsoba
    {
        //properties
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //methods
        void ReturnFullName();
    }
}
