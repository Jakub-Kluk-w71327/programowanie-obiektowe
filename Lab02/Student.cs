namespace programowanie_obiektowe
{
    internal class Student
    {
        //pola
        private string? name;
        private string? surname;
        private List<int>? grades;

        //właściwości
        public string Name
        {
            get
            {
                if (name == null)
                    throw new ArgumentNullException("Pole 'name' nie może być puste");
                return name;
            }
            set { name = value; }
        }
        public string Surname
        {
            get
            {
                if (surname == null)
                    throw new ArgumentNullException("Pole 'surname' nie może być puste");
                return surname;
            }
            set { surname = value; }
        }
        public List<int> Grades
        {
            get
            {
                if (grades == null)
                    throw new ArgumentNullException("Tablica z ocenami jest pusta");
                return grades;
            }
            set { grades = value; }
        }
        public double AvgGrades
        {
            get
            {
                if (grades == null)
                    throw new ArgumentNullException("Tablica z ocenami jest pusta");

                int sum = 0;
                int counter = 0;

                foreach (var grade in grades)
                {
                    sum += grade;
                    counter++;
                }

                return Math.Round((double)sum / counter, 2);
            }
            set { }
        }

        //metody
        public void AddGrade(int value)
        {
            if (grades == null)
                throw new ArgumentNullException("Tablica z ocenami jest pusta");
            grades.Add(value);
        }


        //konstruktor
        public Student(string name, string surname, List<int> grades)
        {
            this.Name = name;
            this.Surname = surname;
            this.Grades = grades;
        }
    }
}
