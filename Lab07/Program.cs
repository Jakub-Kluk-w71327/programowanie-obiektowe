using System;
using System.Collections.Generic;
using ContactManagerSQL.Data;
using ContactManagerSQL.Models;

class Program
{
    // =========================
    // CONNECTION STRING
    // =========================
    const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=ContactDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        var repo = new ContactRepository(ConnectionString);

        while (true)
        {
            PrintMenu();
            string choice = Console.ReadLine() ?? "";

            try
            {
                switch (choice)
                {
                    case "1": Create(repo); break;
                    case "2": ReadAll(repo); break;
                    case "3": Search(repo); break;
                    case "4": Update(repo); break;
                    case "5": Delete(repo); break;
                    case "6": BulkInsertDemo(repo); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }
        }
    }

    static void PrintMenu()
    {
        Console.WriteLine("\n=== CONTACT MANAGER (ADO.NET + DAL) ===");
        Console.WriteLine("1) Dodaj kontakt");
        Console.WriteLine("2) Pokaż wszystkie");
        Console.WriteLine("3) Wyszukaj po nazwisku");
        Console.WriteLine("4) Edytuj kontakt");
        Console.WriteLine("5) Usuń kontakt");
        Console.WriteLine("6) Bulk insert (transakcja) - demo");
        Console.WriteLine("0) Wyjście");
        Console.Write("Wybór: ");
    }

    // =========================
    // CREATE
    // =========================
    static void Create(ContactRepository repo)
    {
        string firstName = ReadRequired("Imię: ");
        string lastName = ReadRequired("Nazwisko: ");
        string? phone = ReadOptional("Telefon (opcjonalnie): ");
        string? email = ReadOptional("Email (opcjonalnie): ");

        var contact = new Contact
        {
            FirstName = firstName,
            LastName = lastName,
            Phone = phone,
            Email = email
        };

        int id = repo.Add(contact);
        Console.WriteLine($"Kontakt dodany. Id = {id}");
    }

    // =========================
    // READ ALL
    // =========================
    static void ReadAll(ContactRepository repo)
    {
        var contacts = repo.GetAll();
        Console.WriteLine("\nId | Imię | Nazwisko | Telefon | Email");
        Console.WriteLine("------------------------------------------");
        foreach (var c in contacts)
        {
            Console.WriteLine(c);
        }
    }

    // =========================
    // SEARCH BY LAST NAME
    // =========================
    static void Search(ContactRepository repo)
    {
        string query = ReadRequired("Fragment nazwiska do wyszukania: ");
        var results = repo.SearchByLastName(query);

        if (results.Count == 0)
        {
            Console.WriteLine("Nie znaleziono kontaktów.");
            return;
        }

        Console.WriteLine("\nId | Imię | Nazwisko | Telefon | Email");
        Console.WriteLine("------------------------------------------");
        foreach (var c in results)
        {
            Console.WriteLine(c);
        }
    }

    // =========================
    // UPDATE
    // =========================
    static void Update(ContactRepository repo)
    {
        int id = ReadInt("Podaj Id kontaktu do aktualizacji: ");

        string firstName = ReadRequired("Nowe imię: ");
        string lastName = ReadRequired("Nowe nazwisko: ");
        string? phone = ReadOptional("Nowy telefon (opcjonalnie): ");
        string? email = ReadOptional("Nowy email (opcjonalnie): ");

        var contact = new Contact
        {
            Id = id,
            FirstName = firstName,
            LastName = lastName,
            Phone = phone,
            Email = email
        };

        bool updated = repo.Update(contact);
        Console.WriteLine(updated ? "Kontakt zaktualizowany." : "Nie znaleziono kontaktu o podanym Id.");
    }

    // =========================
    // DELETE
    // =========================
    static void Delete(ContactRepository repo)
    {
        int id = ReadInt("Podaj Id kontaktu do usunięcia: ");
        bool deleted = repo.Delete(id);
        Console.WriteLine(deleted ? "Kontakt usunięty." : "Nie znaleziono kontaktu o podanym Id.");
    }

    // =========================
    // BULK INSERT DEMO
    // =========================
    static void BulkInsertDemo(ContactRepository repo)
    {
        var contacts = new List<Contact>
    {
        new Contact { FirstName = "Anna", LastName = "Kowalska", Phone = "123456789", Email = "anna@example.com" },
        new Contact { FirstName = "Jan", LastName = "Nowak", Phone = "987654321", Email = "jan@example.com" },
        new Contact { FirstName = "Ewa", LastName = "Wiśniewska", Phone = null, Email = "ewa@example.com" }
    };

        int inserted = repo.BulkInsert(contacts);
        Console.WriteLine($"Dodano {inserted} kontaktów w transakcji.");
    }


    // =========================
    // HELPERS
    // =========================
    static string ReadRequired(string label)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(s)) return s.Trim();
            Console.WriteLine("Pole nie może być puste.");
        }
    }

    static string? ReadOptional(string label)
    {
        Console.Write(label);
        string s = Console.ReadLine() ?? "";
        return string.IsNullOrWhiteSpace(s) ? null : s.Trim();
    }

    static int ReadInt(string label)
    {
        while (true)
        {
            Console.Write(label);
            if (int.TryParse(Console.ReadLine(), out int result))
                return result;
            Console.WriteLine("Nieprawidłowa liczba.");
        }
    }
}
