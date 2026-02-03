namespace programowanie_obiektowe
{
    internal class Adder //sumator
    {
        //pola
        private int[]? numbers;
        
        //metody
        public void Sum()
        {
            int sum = 0;

            if (numbers == null)
                throw new ArgumentNullException("Tablica 'numbers' jest pusta");

            foreach (var element in numbers)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }
        public void SumDivTwo()
        {
            if (numbers == null)
                throw new ArgumentNullException("Tablica 'numbers' jest pusta");

            int sum = 0;

            foreach (var element in numbers)
            {
                sum += element;
            }

            Console.WriteLine(Math.Round((double)sum/2, 2));
        }
        public void CountElements()
        {
            if (numbers == null)
                throw new ArgumentNullException("Tablica 'numbers' jest pusta");

            Console.WriteLine(numbers.Length);
        }
        public void ShowTable()
        {
            if (numbers == null)
                throw new ArgumentNullException("Tablica 'numbers' jest pusta");

            Console.WriteLine(string.Join(", ", numbers));
        }

        public void ShowElements(int lowIndex, int highIndex)
        {
            List<int> tempTable = new List<int>();

            if (numbers == null)
                throw new ArgumentNullException("Tablica 'numbers' jest pusta");

            int start = Math.Max(0, lowIndex);
            int end = Math.Min(numbers.Length-1, highIndex);

            for (int i = start; i <= end; i++)
            {
                tempTable.Add(numbers[i]);
            }


            Console.WriteLine(string.Join(", ", tempTable));
        }

        //konstruktor
        public Adder(int[] value)
        {
            numbers = value;
        }
    }
}
