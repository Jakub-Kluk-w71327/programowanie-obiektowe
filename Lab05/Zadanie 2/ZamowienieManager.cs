using System;
using System.Collections.Generic;

namespace Lab05
{
    enum StatusZamowienia
    {
        Oczekujace,
        Przyjete,
        Zrealizowane,
        Anulowane
    }
    internal class ZamowienieManager
    {
        public Dictionary<int, List<string>> Zamowienia = new Dictionary<int, List<string>>();
        public Dictionary<int, StatusZamowienia> Statusy = new Dictionary<int, StatusZamowienia>();

        public void ZmienStatus(int numer, StatusZamowienia nowyStatus)
        {
            if (!Statusy.ContainsKey(numer))
                throw new KeyNotFoundException("Nie ma takiego zamówienia.");

            if (Statusy[numer] == nowyStatus)
                throw new ArgumentException("Nowy status jest taki sam jak obecny.");

            Statusy[numer] = nowyStatus;
        }

        public void WyswietlZamowienia()
        {
            foreach (var zam in Zamowienia)
            {
                Console.WriteLine("Zamówienie nr " + zam.Key);
                Console.WriteLine("Status: " + Statusy[zam.Key]);
                Console.WriteLine("Produkty:");
                foreach (string p in zam.Value)
                {
                    Console.WriteLine("- " + p);
                }
                Console.WriteLine();
            }
        }
    }
}
