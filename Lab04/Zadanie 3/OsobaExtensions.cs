using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class OsobaExtensions
    {
        public static void WypiszOsoby (this List<IOsoba> osoby)
        {
            foreach (var o in osoby)
            {
                Console.WriteLine ($"{o.FirstName} {o.LastName}");
            }
        }

        public static void PosortujOsobyPoNazwisku (this List<IOsoba> osoby)
        {
            osoby.Sort((a, b) =>
                string.Compare(a?.LastName, b?.LastName, StringComparison.Ordinal)
            );

        }
    }
}
