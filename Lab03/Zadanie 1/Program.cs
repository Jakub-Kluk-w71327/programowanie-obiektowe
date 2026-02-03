using PO_Lab03;

class Program
{
    static void Main(string[] args)
    {
        //Zadanie 1a
        Console.WriteLine("\nZadanie 1a:\n");
        Person person1 = new Person("Sally", "Rooney", 34);
        Person person2 = new Person("Danielle", "Steel", 78);

        person1.View();
        person2.View();

        Book book1 = new Book("Normal People", person1, new DateOnly(2018, 01, 01));
        Book book2 = new Book("Jewels", person2, new DateOnly(1992, 01, 01));

        book1.View();
        book2.View();


        //Zadanie 1b
        Console.WriteLine("\nZadanie 1b:\n");
        Reader reader1 = new Reader("Mariusz", "Pudzianowski", 45);
        Reader reader2 = new Reader("Iga", "Świątek", 27);

        reader1.AddBook(book1);
        reader2.AddBook(book2);

        reader1.ViewBook();
        reader2.ViewBook();

        //Zadanie 1c
        Console.WriteLine("\nZadanie 1c:\n");
        reader1.View();

        //Zadanie 1d
        Console.WriteLine("\nZadanie 1d:\n");
        Person o = new Reader("Marta", "Dąbrowska", 34);
        o.View();

        //Zadanie 1e
        Console.WriteLine("\nZadanie 1e:\n");
        Console.WriteLine("W klasie person dodano odpowiednie właściwości.");

        //Zadanie 1f
        Console.WriteLine("\nZadanie 1f:\n");
        Reviewer reviewer1 = new Reviewer("Jakub", "Kluk", 21);
        Reviewer reviewer2 = new Reviewer("Marek", "Posłuszny", 25);

        reviewer1.AddBook(book1);
        reviewer1.AddBook(book2);

        reviewer2.AddBook(book1);
        reviewer2.AddBook(book2);

        reviewer1.Wypisz();
        reviewer2.Wypisz();

        //Zadanie 1g
        Console.WriteLine("\nZadanie 1g:\n");
        List<Person> people = new List<Person>();
        people.Add(reader1);
        people.Add(reviewer1);

        foreach (Person person in people)
        {
            person.View();
            Console.WriteLine();
        }

        //Zadanie 1h
        Console.WriteLine("\nZadanie 1h:\n");
        Console.WriteLine("Dodano właściwość Title do klasy Book.");

        //Zadanie 1i
        Console.WriteLine("\nZadanie 1i:\n");
        Console.WriteLine("Dodano klasę AdventureBook oraz DocumentaryBook.");
    }
}