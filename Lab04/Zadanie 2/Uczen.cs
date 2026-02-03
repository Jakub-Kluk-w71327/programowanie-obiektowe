
namespace Lab03_ćwiczenia
{
    internal class Uczen : Osoba
    {
        //properties
        public string? School { get; set; }
        public bool MozeSamWracacDoDomu { get; set; }

        //methods
        public void SetSchool(string? School)
        {
            this.School = School;
        }
        public void ChangeSchool(string? NewSchool)
        {
            this.School = NewSchool;
        }
        public void SetCanGoHomeAlone()
        {
            this.MozeSamWracacDoDomu = true;
        }

        public override void GetEducationInfo()
        {
            Console.WriteLine($"Szkoła: {School}");
        }
        public override void GetFullName()
        {
            Console.WriteLine($"Imię i nazwisko: {firstName} {lastName}");
        }
        public override bool CanGoAloneToHome()
        {
            return MozeSamWracacDoDomu;
        }
        public void Info()
        {
            Console.WriteLine($"Imię: {firstName}, Nazwisko: {lastName}, Wiek: {GetAge()}, Szkoła: {School}");

            if (CanGoAloneToHome() || GetAge() > 11)
                Console.WriteLine("Może sam wracać do domu.");
            else
                Console.WriteLine("Nie może sam wracać do domu.");

            Console.WriteLine();
        }
    }
}
