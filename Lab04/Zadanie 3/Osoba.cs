namespace ConsoleApp1
{
    internal class Osoba : IOsoba
    {
        //properties
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //methods
        public void ReturnFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        //constructors
        public Osoba(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
