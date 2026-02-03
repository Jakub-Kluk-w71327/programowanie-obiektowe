namespace programowanie_obiektowe
{
    internal class Person
    {
        //pola
        private string? firstName, lastName;
        private int age;

        //public ; protected;

        //właściwości
        public string FirstName
        {
            get
            {
                if (firstName == null) throw new ArgumentException("Pole 'firstName' nie może być null");
                return firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Pole 'imię' musi zawierać conajmniej 2 znaki");
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                if (lastName == null) throw new ArgumentException("Pole 'firstName' nie może być null");
                return lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Pole 'nazwisko' musi zawierać conajmniej 2 znaki");
                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Pole 'wiek' nie może być ujemne");
                age = value;
            }
        }


        //metody
        public void View()
        {
            Console.WriteLine($"Imie: {firstName}" + $"\t\t Nazwisko: {lastName}" + $"\t\t wiek: {age}");
        }


        //konstruktor
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
