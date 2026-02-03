namespace programowanie_obiektowe
{
    internal class Count
    {
        //pola
        private int value;

        //metody
        public void Addition(int new_number)
        {
            if(new_number > 0)
            {
                value += new_number;
            }
            else
            {
                throw new ArgumentException("Podana wartość musi być dodatnia");
            }
        }
        public void Subtraction(int new_number)
        {
            if (new_number > 0)
            {
                value -= new_number;
            }
            else
            {
                throw new ArgumentException("Podana wartość musi być dodatnia");
            }
        }
        public void View()
        {
            Console.WriteLine(value);
        }

        //konstruktor
        public Count(int start)
        {
            value = start; //inicjalizacja pola value (Przekazanie wartości zdefiniowane w momencie tworzenia nowego obiektu)
        }
    }
}
