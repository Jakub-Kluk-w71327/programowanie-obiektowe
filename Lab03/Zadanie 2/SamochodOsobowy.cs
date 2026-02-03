namespace ConsoleApp1
{
    class SamochodOsobowy : Samochod
    {
        //fields
        private double? weight;
        private double? engineCapacity;

        //properties
        public double? Weight
        {
            get => weight;
            set
            {
                if (!(value > 1.9 && value < 4.6))
                    throw new ArgumentException("Podano nieprawidłową wagę");
                weight = value;
            }
        }
        public double? EngineCapacity
        {
            get => engineCapacity;
            set
            {
                if (!(value > 0.7 && value < 3.1))
                    throw new ArgumentException("Podano nieprawidłową pojemność silnika");
                engineCapacity = value;
            }
        }
        public int? Seats { get; set; }

        //methods
        public override void ViewCar()
        {
            Console.WriteLine($"{Marka} {Model}, {Kolor}, {RokProdukcji}, {Przebieg} km, {Weight}t, {EngineCapacity}l, {Seats} miejsca siedzące");
        }


        //constructor
        public SamochodOsobowy(string? marka, string? model, string? nadwozie, string? kolor, int? rokProdukcji, int? przebieg, double? weight, double? engineCapacity, int? seats) : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            this.Weight = weight;
            this.EngineCapacity = engineCapacity;
            this.Seats = seats;
        }
    }
}
