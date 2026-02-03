namespace Lab03_ćwiczenia
{
    internal class Nauczyciel : Uczen
    {
        //properties
        public string? TytulNaukowy {  get; set; }
        public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

        //methods
        public void WhichStudentCanGoHomeAlone()
        {
            foreach(Uczen student in PodwladniUczniowie ?? throw new ArgumentNullException("Żaden uczeń nie może wyjść wcześniej!"))
            {
                student.Info();
            }

        }
        public void AddStudent(Uczen student)
        {
            this.PodwladniUczniowie.Add(student);
        }
    }
}
