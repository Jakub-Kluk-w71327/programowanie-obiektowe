namespace PO_Lab03
{
    class Reader : Person
    {
        //pola
        protected List<Book> readBooks = new List<Book>();


        //metody
        public void ViewBook()
        {
            foreach (Book book in readBooks)
            {
                Console.WriteLine(book.Title);
  
            }
        }

        public void AddBook(Book book)
        {
            readBooks.Add(book);
        }

        public override void View()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            ViewBook();
        }

        //konstruktor
        public Reader(string? firstName, string? lastName, int age) : base(firstName, lastName, age)
        {

        }
    }
}
