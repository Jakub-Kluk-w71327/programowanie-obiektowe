using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        SamochodOsobowy passengerCar1 = new SamochodOsobowy("Audi", "A4", "Sedan", "Biały", 2018, 89000, 2, 3, 4);
        passengerCar1.ViewCar();



        Samochod car1 = new Samochod("BMW", "X5", "SUV", "Czarny", 2020, 10);
        car1.ViewCar();

        Samochod car2 = new Samochod();
        car2.ViewCar();

        Console.ReadLine();
    }
}
