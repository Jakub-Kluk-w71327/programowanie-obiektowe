using System;
using System.Collections.Generic;   

namespace Lab05
{
    enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Zolty,
        Fioletowy
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kolor> kolory = new List<Kolor>
            {
                Kolor.Czerwony,
                Kolor.Niebieski,
                Kolor.Zielony,
                Kolor.Zolty,
                Kolor.Fioletowy
            };

            Random rand = new Random();

            Kolor wylosowany = kolory[rand.Next(kolory.Count)];

            bool odgadniety = false;

            while (!odgadniety)
            {
                Console.Write("Podaj kolor: ");
                string input = Console.ReadLine();

                try
                {
                    Kolor zgadywany; //deklaracja zmiennej zgadywany typu Kolor
                    if (!Enum.TryParse(input, true, out zgadywany) || !kolory.Contains(zgadywany)) //próba zamiana tekstu na enum Kolor. true = ignoruje wielkość liter. || czy kolor znaduje się na liście kolory
                        throw new ArgumentException("Nieprawidłowy kolor.");

                    if (zgadywany == wylosowany)
                    {
                        Console.WriteLine("Brawo! Odgadłeś kolor");
                        odgadniety = true;
                    }
                    else
                    {
                        Console.WriteLine("Nie tym razem, spróbuj ponownie.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Błąd: " + ex.Message);
                }
            }
        }
    }

}
