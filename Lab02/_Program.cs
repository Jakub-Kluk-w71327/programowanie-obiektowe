using programowanie_obiektowe;

///<remarks>
///Autor: Jakub Kluk
///Data: 26.10.2025
///Środowisko: .net8.0
/// </remarks>

//Zadanie 1
Console.WriteLine("\n Zadanie 1");

//Wyświetlanie jednego obiektu
Person person = new ("aa", "bb", 0);
person.View();

//Tablica obiektów Person
Person[] people = new Person[3];
people[0] = new("Maria", "Kowalska", 25);
people[1] = new("Julia", "Wesołowska", 31);
people[2] = new("Matylda", "Czereśniowska", 22);

foreach (Person p in people)
    p.View();



//Zadanie 2
Console.WriteLine("\n Zadanie 2");
BankAccount account = new("Jan Kowalski", 1000);
account.Deposit(500);
account.Withdrawal(200);
Console.WriteLine($"Właściciel {account.Owner} \t Saldo: {account.Amount}");



//Zadanie 3
Console.WriteLine("\n Zadanie 3");
Student student = new("Jan", "Kowalski", [2, 5, 3, 7]);
student.AddGrade(5);
student.AddGrade(6);
Console.WriteLine(student.AvgGrades);


//Zadanie 4
Console.WriteLine("\n Zadanie 4");
Count count1 = new(543);
Count count2 = new(123);
Count count3 = new(456);
count1.Addition(1594);
count1.Subtraction(1471);
count2.Subtraction(52);
count2.Subtraction(1234);
count3.Addition(643);
count3.Addition(853);
count1.View();
count2.View();
count3.View();


//Zadanie 5
Console.WriteLine("\n Zadanie 5");

Adder adder = new([5, 10, 15, 20, 25, 30]);

adder.Sum();
adder.SumDivTwo();
adder.CountElements();
adder.ShowTable();
adder.ShowElements(2,4);