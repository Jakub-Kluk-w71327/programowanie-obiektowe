
namespace PO_Lab03
{
    class DocumentaryBook : Book
    {
        //pola
        public string? Subject;
        public int? Pages;

        public DocumentaryBook(string? title, Person? author, DateOnly releaseDate) : base(title, author, releaseDate)
        {

        }
    }
}
