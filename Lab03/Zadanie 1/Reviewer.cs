namespace PO_Lab03
{
    class Reviewer : Reader
    {
        //metody
        public void Wypisz()
        {
            Console.Write($"Użytkownik: {FirstName} {LastName} \n");
            Console.WriteLine("Lista przeczytanych książek: ");
            foreach(Book e in readBooks)
            {
                Console.WriteLine(e.Title + " " + randomRate());
            }
            Console.WriteLine();
        }
        public new void AddBook(Book book)
        {
            readBooks.Add(book);
        }

        private double randomRate()
        {
            var rand = new Random();
            int liczba = rand.Next(400, 501); //400-500
            double value = liczba / 100.0;
            return value;
        }

        //konstruktor
        public Reviewer(string? firstName, string? lastName, int age) : base(firstName, lastName, age)
        {

        }
    }
}
