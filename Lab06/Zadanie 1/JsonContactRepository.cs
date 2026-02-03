using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


namespace Lab06
{
    internal class JsonContactRepository
    {
        private readonly string _path;

        public JsonContactRepository(string path)
        {
            _path = path;
            if (!File.Exists(_path))
                File.WriteAllText(_path, "[]");
        }

        public List<Contact> GetAll()
        {
            var json = File.ReadAllText(_path);
            return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
        }

        public void Add(Contact contact)
        {
            var contacts = GetAll();
            if (contacts.Any(c => c.Id == contact.Id))
                throw new InvalidOperationException("Kontakt o takim Id już istnieje.");

            contacts.Add(contact);
            SaveAll(contacts);
        }

        public void Delete(Contact contact)
        {
            var contacts = GetAll();
            var toRemove = contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (toRemove == null)
                throw new InvalidOperationException("Nie znaleziono kontaktu");

            contacts.Remove(toRemove);
            SaveAll(contacts);
        }

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
            var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_path, json);
        }
    }
}
