
namespace PO_Lab03
{
    class AdventureBook : Book
    {
        //pola
        public string? setting; //miejsce akcji przygody
        public int? dangerLevel;

        public AdventureBook(string? title, Person? author, DateOnly releaseDate) : base(title, author, releaseDate)
        {

        }
    }
}
