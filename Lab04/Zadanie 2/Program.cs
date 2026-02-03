namespace Lab03_ćwiczenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //person

            Uczen person = new Uczen();
            person.SetFirstName("Andrzej");
            person.SetLastName("Motyka");
            person.SetPesel("13320900231");
            Console.WriteLine($"Wiek: {person.GetAge()}");
            Console.WriteLine($"Płeć: {person.GetGender()}");
            person.SetSchool("SP nr.3");
            person.GetEducationInfo();
            person.ChangeSchool("SP nr.4");
            person.GetEducationInfo();
            person.Info();

            Console.WriteLine();
            

            // person1
            Uczen person1 = new Uczen();
            person1.SetFirstName("Anna");
            person1.SetLastName("Kowalska");
            person1.SetPesel("23210512345");
            person1.SetSchool("SP nr.1");


            // Uczeń 2
            Uczen person2 = new Uczen();
            person2.SetFirstName("Piotr");
            person2.SetLastName("Nowak");
            person2.SetPesel("01120867890");
            person2.SetSchool("SP nr.2");


            // Uczeń 3
            Uczen person3 = new Uczen();
            person3.SetFirstName("Maria");
            person3.SetLastName("Wiśniewska");
            person3.SetPesel("23210354321");
            person3.SetSchool("SP nr.3");


            // Uczeń 4
            Uczen person4 = new Uczen();
            person4.SetFirstName("Kamil");
            person4.SetLastName("Lewandowski");
            person4.SetPesel("17090198765");
            person4.SetSchool("SP nr.4");



            Nauczyciel teacher = new Nauczyciel();

            teacher.AddStudent(person1);
            teacher.AddStudent(person2);
            teacher.AddStudent(person3);
            teacher.AddStudent(person4);

            teacher.WhichStudentCanGoHomeAlone();
        }
    }
}