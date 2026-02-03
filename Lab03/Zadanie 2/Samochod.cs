namespace ConsoleApp1
{
    class Samochod
    {
        //fields
        private int? przebieg;

        //properties
        public string? Marka {  get; set; }
        public string? Model {  get; set; }
        public string? Nadwozie {  get; set; }
        public string? Kolor {  get; set; }
        public int? RokProdukcji {  get; set; }
        public int? Przebieg {
            get => przebieg;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Przebieg nie może być ujemny");
                przebieg = value;
            }
        }

        //constructor
        public Samochod() // Konstruktor 1 — pobiera dane od użytkownika
        {
            Console.Write("Marka: ");
            Marka = Console.ReadLine();

            Console.Write("Model: ");
            Model = Console.ReadLine();

            Console.Write("Nadwozie: ");
            Nadwozie = Console.ReadLine();

            Console.Write("Kolor: ");
            Kolor = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            string? input = Console.ReadLine();
            int rok;
            while (!int.TryParse(input, out rok))
            {
                Console.WriteLine("Podaj poprawną liczbę!"); //throw 
                input = Console.ReadLine();
            }
            RokProdukcji = rok;

            Console.Write("Przebieg: ");
            input = Console.ReadLine();
            int przebieg;
            while(!int.TryParse(input, out przebieg))
            {
                Console.WriteLine("Podaj prawidłowy przebieg");
                input = Console.ReadLine();
            }
            Przebieg = przebieg;
        }
        public Samochod(string? marka, string? model, string? nadwozie, string? kolor, int? rokProdukcji, int? przebieg) // Konstruktor 2 — przeciążony, przyjmuje wartości pól
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        //methods
        public virtual void ViewCar()
        {
            Console.WriteLine($"{Marka} {Model}, {Kolor}, {RokProdukcji}, {Przebieg} km");
        }
    }
}
