using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba person1 = new Osoba("Jakub", "Kluk");
            Osoba person2 = new Osoba("Marta", "Dąbrowska");
            Osoba person3 = new Osoba("Marcin", "Gawryl");
            Osoba person4 = new Osoba("Matylda", "Częstochowska");

            //Zadanie 3a

            List<Osoba> collection = new List<Osoba>();
            collection.Add(person1);    
            collection.Add(person2);
            collection.Add(person3);
            collection.Add(person4);

            //Zadanie 3b
            Console.WriteLine("Zadanie 3b");

            List<IOsoba> collection1 = new List<IOsoba>();
            collection1.Add(person1);
            collection1.Add(person2);
            collection1.Add(person3);
            collection1.Add(person4);

            collection1.WypiszOsoby();
            Console.WriteLine();

            //Zadanie 3c
            Console.WriteLine("Zadanie 3c");
            collection1.PosortujOsobyPoNazwisku();
            
            collection1.WypiszOsoby();
            Console.WriteLine();

            //Zadanie 3e
            Console.WriteLine("Zadanie 3e");
            //Jan Kowalski – 4IID-P 2018 WSIiZ
            StudentWSIiZ studentWSIiZ1 = new StudentWSIiZ("Anna", "Nowak", 1, "INF-D", 2023, "WSIiZ");
            StudentWSIiZ studentWSIiZ2 = new StudentWSIiZ("Piotr", "Zieliński", 3, "GRAF-P", 2021, "WSIiZ");
            StudentWSIiZ studentWSIiZ3 = new StudentWSIiZ("Katarzyna", "Wójcik", 2, "ADM-D", 2022, "WSIiZ");
            StudentWSIiZ studentWSIiZ4 = new StudentWSIiZ("Marek", "Jankowski", 4, "PROG-P", 2020, "WSIiZ");


            List<StudentWSIiZ> students_wsiiz_collection = new List<StudentWSIiZ>();

            students_wsiiz_collection.Add(studentWSIiZ1);
            students_wsiiz_collection.Add(studentWSIiZ2);
            students_wsiiz_collection.Add(studentWSIiZ3);
            students_wsiiz_collection.Add(studentWSIiZ4);

            foreach(StudentWSIiZ s in  students_wsiiz_collection)
            {
                s.GetFullUniversityName();
            }
        }
    }
}
