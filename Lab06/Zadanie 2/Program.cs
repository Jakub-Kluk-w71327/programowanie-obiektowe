using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PopulationAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFile = "db.json";
            if (!File.Exists(jsonFile))
            {
                Console.WriteLine("Brak pliku db.json!");
                return;
            }

            var jsonData = File.ReadAllText(jsonFile);
            var records = JsonSerializer.Deserialize<List<PopulationRecord>>(jsonData);

            var service = new PopulationService(records);

            while (true)
            {
                Console.WriteLine("\n--- Population Analyzer ---");
                Console.WriteLine("1. Różnica populacji dla Indii (1970-2000)");
                Console.WriteLine("2. Różnica populacji dla USA (1965-2010)");
                Console.WriteLine("3. Różnica populacji dla Chin (1980-2018)");
                Console.WriteLine("4. Wyświetl populację dla wybranego roku i kraju");
                Console.WriteLine("5. Różnica populacji dla wybranego kraju i lat");
                Console.WriteLine("6. Procentowy wzrost populacji dla kraju");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybierz opcję: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ShowDifference(service, "India", 1970, 2000);
                        break;
                    case "2":
                        ShowDifference(service, "United States", 1965, 2010);
                        break;
                    case "3":
                        ShowDifference(service, "China", 1980, 2018);
                        break;
                    case "4":
                        ShowPopulation(service);
                        break;
                    case "5":
                        ShowCustomDifference(service);
                        break;
                    case "6":
                        ShowPercentageGrowth(service);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        break;
                }
            }
        }

        static void ShowDifference(PopulationService service, string country, int startYear, int endYear)
        {
            long diff = service.GetPopulationDifference(country, startYear, endYear);
            Console.WriteLine($"Różnica populacji w {country} między {startYear} a {endYear}: {diff:N0}");
        }

        static void ShowPopulation(PopulationService service)
        {
            Console.Write("Podaj kraj: ");
            string country = Console.ReadLine();
            Console.Write("Podaj rok: ");
            int year = int.Parse(Console.ReadLine());
            long population = service.GetPopulation(country, year);
            Console.WriteLine($"Populacja w {country} w roku {year}: {population:N0}");
        }

        static void ShowCustomDifference(PopulationService service)
        {
            Console.Write("Podaj kraj: ");
            string country = Console.ReadLine();
            Console.Write("Podaj rok początkowy: ");
            int startYear = int.Parse(Console.ReadLine());
            Console.Write("Podaj rok końcowy: ");
            int endYear = int.Parse(Console.ReadLine());

            long diff = service.GetPopulationDifference(country, startYear, endYear);
            Console.WriteLine($"Różnica populacji w {country} między {startYear} a {endYear}: {diff:N0}");
        }

        static void ShowPercentageGrowth(PopulationService service)
        {
            Console.Write("Podaj kraj: ");
            string country = Console.ReadLine();

            Console.Write("Podaj rok końcowy: ");
            int endYear = int.Parse(Console.ReadLine());

            var growth = service.GetPercentageGrowth(country, endYear);

            if (growth.Count == 0)
            {
                Console.WriteLine($"Brak danych dla {country} do roku {endYear}.");
                return;
            }

            Console.WriteLine($"\nProcentowy wzrost populacji dla {country} do roku {endYear}:");
            foreach (var kvp in growth)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value:F2}%");
            }
        }
    }
}
