namespace Lab06
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal class TxtContactRepository
    {
        //nazwa pliku
        private readonly string _path;

        //konstruktor klasy z parametrem do ścieżki
        public TxtContactRepository(string path)
        {
            _path = path;
            EnsureFileExists();
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(_path))
                File.WriteAllText(_path, "");
        }

        public List<Contact> GetAll()
        {
            var lines = File.ReadAllLines(_path);
            var contacts = new List<Contact>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(';');
                if (parts.Length != 3) continue;

                if (!int.TryParse(parts[0], out var id)) continue;

                contacts.Add(new Contact
                {
                    Id = id,
                    Name = parts[1],
                    Email = parts[2]
                });
            }

            return contacts;
        }

        //Create
        public void Add(Contact contact)
        {
            var contacts = GetAll();
            if (contacts.Any(c => c.Id == contact.Id))
                throw new InvalidOperationException("Kontakt o takim Id już istnieje.");

            File.AppendAllText(_path, $"{contact.Id};{contact.Name};{contact.Email}{Environment.NewLine}");
        }

        //Remove
        public void Delete(Contact contact)
        {
            var contacts = GetAll();
            var toRemove = contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (toRemove == null)
                throw new InvalidOperationException("Nie znaleziono kontaktu");

            contacts.Remove(toRemove);
            SaveAll(contacts);
        }

        //Update data
        public void Update(Contact contact)
        {
            var contacts = GetAll();
            var existing = contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existing == null)
                throw new InvalidOperationException("Nie znaleziono kontaktu");

            existing.Name = contact.Name;
            existing.Email = contact.Email;

            SaveAll(contacts);
        }

        private void SaveAll(List<Contact> contacts)
        {
            var lines = contacts.Select(c => $"{c.Id};{c.Name};{c.Email}");
            File.WriteAllLines(_path, lines);
        }
    }
}
