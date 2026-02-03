using System;
using System.Collections.Generic;

namespace Lab05
{
    enum Operacja
    {
        Dodawanie = 1,
        Odejmowanie = 2,
        Mnozenie = 3,
        Dzielenie = 4
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> historiaWynikow = new List<double>();
            while (true)
            { 
                try
                {
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Podaj drugą liczbę: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Wybierz operację:");
                    Console.WriteLine("1 - Dodawanie");
                    Console.WriteLine("2 - Odejmowanie");
                    Console.WriteLine("3 - Mnożenie");
                    Console.WriteLine("4 - Dzielenie");

                    Operacja operacja = (Operacja)int.Parse(Console.ReadLine());
                    double wynik = 0;

                    switch (operacja)
                    {
                        case Operacja.Dodawanie:
                            wynik = a + b;
                            break;
                        case Operacja.Odejmowanie:
                            wynik = a - b;
                            break;
                        case Operacja.Mnozenie:
                            wynik = a * b;
                            break;
                        case Operacja.Dzielenie:
                            if (b == 0)
                                throw new DivideByZeroException();
                            wynik = a / b;
                            break;
                        default:
                            Console.WriteLine("Nieznana operacja.");
                            return;
                    }

                    historiaWynikow.Add(wynik);
                    Console.WriteLine("Wynik: " + wynik);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: podano nieprawidłowe dane.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Błąd: dzielenie przez zero.");
                }

                Console.WriteLine("Historia wyników:");
                foreach (double w in historiaWynikow)
                {
                    Console.WriteLine(w);
                }
            }
        }
    }
}
