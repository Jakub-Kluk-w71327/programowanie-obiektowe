namespace PO_Lab03
{
    class Person
    {
        //pola
        private string? firstName;
        private string? lastName;
        private int? age;

        //właściwości
        public string? FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string? LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        //metody
        public virtual void View()
        {
           Console.WriteLine(this);// → używa ToString()
        }
        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }

        //kontruktor
        public Person(string? firstName, string? lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
