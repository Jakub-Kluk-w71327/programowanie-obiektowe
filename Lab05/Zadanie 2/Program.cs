using System;
using System.Collections.Generic;   

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZamowienieManager manager = new ZamowienieManager();

            manager.Zamowienia.Add(1, new System.Collections.Generic.List<string> { "Chleb", "Masło" });
            manager.Statusy.Add(1, StatusZamowienia.Oczekujace);

            try
            {
                manager.ZmienStatus(1, StatusZamowienia.Przyjete);
                manager.WyswietlZamowienia();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
        }
    }

}
