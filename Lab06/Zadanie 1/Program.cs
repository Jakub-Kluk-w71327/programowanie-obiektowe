using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic repo; //zmienna typu dynamicznego. typ zmiennej ustalony będzie podczas działania programu, a nie w momencie kompilacji programu

            bool useJson = false;
            if (useJson)
                repo = new JsonContactRepository("contacts.json");
            else
                repo = new TxtContactRepository("contacts.txt");


            while (true)
            {
                Console.WriteLine("\n--- Contact Manager ---");
                Console.WriteLine("1. Pokaż kontakty");
                Console.WriteLine("2. Dodaj kontakt");
                Console.WriteLine("3. Edytuj kontakt");
                Console.WriteLine("4. Usuń kontakt");
                Console.WriteLine("0. Wyjdź");
                Console.Write("Wybierz opcję: ");

                string choice = Console.ReadLine() ?? "";

                try
                {
                    switch (choice)
                    {
                        case "1": ShowAll(repo); break;
                        case "2": Add(repo); break;
                        case "3": Update(repo); break;
                        case "4": Delete(repo); break;
                        case "0": return;
                        default: Console.WriteLine("Nieznana opcja"); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
        }

        private static void ShowAll(dynamic repo)
        {
            var contacts = repo.GetAll();
            if (contacts.Count == 0)
            {
                Console.WriteLine("Brak kontaktów");
                return;
            }

            Console.WriteLine("\nID\tImię i nazwisko\tEmail");
            foreach (var c in contacts)
            {
                Console.WriteLine($"{c.Id}\t{c.Name}\t{c.Email}");
            }
        }

        private static void Add(dynamic repo)
        {
            var contact = ReadData(true);
            repo.Add(contact);
            Console.WriteLine("Dodano kontakt!");
        }

        private static void Update(dynamic repo)
        {
            var contact = ReadData(true);
            repo.Update(contact);
            Console.WriteLine("Zaktualizowano kontakt!");
        }

        private static void Delete(dynamic repo)
        {
            var contact = ReadData(true);
            repo.Delete(contact);
            Console.WriteLine("Usunięto kontakt!");
        }

        private static Contact ReadData(bool readId)
        {
            int id = 0;
            if (readId)
            {
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine() ?? "0");
            }

            Console.Write("Imię i nazwisko: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            return new Contact
            {
                Id = id,
                Name = name,
                Email = email
            };
        }
    }
}
