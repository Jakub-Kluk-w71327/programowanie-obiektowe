namespace PO_Lab03
{
    class Book
    {
        //pola
        protected string? title;
        protected Person? author;
        protected DateOnly releaseDate;

        public string? Title
        {
            get => title;
            set => title = value;
        }

        //metody
        public void View()
        {
            Console.WriteLine($"Tytuł: {title}\n" + $"Autor: {author}\n" + $"Data wydania książki: {releaseDate}\n");
        }

        //konstruktor
        public Book(string? title, Person? author, DateOnly releaseDate)
        {
            this.title = title;
            this.author = author;
            this.releaseDate = releaseDate;
        }

    }
}
