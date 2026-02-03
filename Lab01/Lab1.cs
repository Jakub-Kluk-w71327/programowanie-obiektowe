namespace programowanie_obiektowe
{
    /// <summary>
    /// Zestaw metod realizujących zadania laboratoryjne 1
    /// </summary>
    /// 

    ///<remarks>
    ///Autor: Jakub Kluk
    ///Data: 12.10.2025
    ///Środowisko: .net8.0
    /// </remarks>

    internal class Lab1
    {
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Wybierz numer zadania (1-5): ");
            string? value = Console.ReadLine();


             if (int.TryParse(value, out int n))
             {
                switch (n)
                {
                    case 1:
                        Zadanie1();
                        Run();
                        break;

                    case 2:
                        Zadanie2();
                        Run();
                        break;

                    case 3:
                        Zadanie3();
                        Run();
                        break;

                    case 4:
                        Zadanie4();
                        Run();
                        break;

                    case 5:
                        Zadanie5();
                        Run();
                        break;

                    default:
                        Run();
                        break;
                }
            }
            else if (string.IsNullOrEmpty(value))
            {
                Run();
            }
            else
            {
                Run();
            }
        }

        /// <summary>
        /// Zadanie 1: Oblicza wyróżnik delty i wyznacza pierwiastki równania kwadratowego
        /// </summary>
        private void Zadanie1()
        {
            double delta, x1, x2;
            Console.WriteLine("Podaj wartość a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wartość b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wartość c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                delta = (b * b) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiązania w zbiorze liczb rzeczywistych");
                }
                else if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Dwa rozwiązania x1 {x1:F2} \t x2 {x2:F2}");
                }
                else
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine($"Rozwiązanie x1 {x1:F2}");
                }

            }
            else
            {
                Console.WriteLine("To nie jest równanie kwadratowe");
            }


        }

        /// <summary>
        /// Zadanie 2: Działanie na tablicy oraz wyzanczanie wartości z użyciem funkcji wbudowanych
        /// </summary>
        private void Zadanie2()
        {
            int suma = 0;
            int iloczyn = 1;
            double min = 0, max = 0, srednia = 0;

            double[] tabDouble = LosujTabliceDouble(5, 1, 10); //losowanie 10 liczb w zakresie 0 - 100

            Console.WriteLine("\n");

            int[] tabInt = new int[tabDouble.Length]; //tablica nie może być pusta

            for (int i = 0; i < tabDouble.Length; i++) //przepisanie do tabInt elementów z tabDouble bez części ułamkowej
            {
                tabInt[i] = (int)tabDouble[i];
            }


            Console.WriteLine(string.Join("\t", tabInt)); //wyświetlanie tablicy


            foreach (int element in tabInt) //sumowanie i mnożenie
            {
                suma += element;
                iloczyn *= element;
            }

            Console.WriteLine("\n");

            Console.WriteLine($"Wynik sumowania to: {suma}");
            Console.WriteLine($"Wynik mnożenia wszystkich elementów w tablicy to: {iloczyn}");

            foreach (int element in tabInt) //średnia, min i max
            {
                srednia = tabInt.Average();
                min = tabInt.Min();
                max = tabInt.Max();
            }
            Console.WriteLine($"Średnia {srednia:F2} Min {min} Max {max}");

        }

        /// <summary>
        /// Losuje tablicę n liczb double z przedziału [min, max].
        /// </summary>
        private double[] LosujTabliceDouble(int n, double min, double max)
        {
            var rng = new Random(); // opcjonalnie: nowy Random(seed) dla powtarzalności
            double[] arr = new double[n]; // tworzenie tablicy n-elementowej
            double zakres = max - min;
            for (int i = 0; i < n; i++)
            {
                // NextDouble() -> [0,1), skalujemy do [min, max]
                arr[i] = min + rng.NextDouble() * zakres;
            }
            return arr;
        }

        /// <summary>
        /// Zadanie 3: Używając intrukcji continue napisz program wyświetlający liczby od 20-0, z wyłączeniem liczb {2,6,9,15,19}
        /// </summary>

        private void Zadanie3()
        {
            Console.WriteLine("\n");

            for (int i = 20; i >= 0; i--)
            {
                if (new int[] { 2, 6, 9, 15, 19 }.Contains(i)) //jeżeli aktualne i jest równe któremukolwiek elementowi tablicy to
                {
                    continue; //przechodzimy do następnej iteracji
                }
                Console.WriteLine(i);

            }
        }

        /// <summary>
        /// Zadanie 4: Pytaj użytkownika w nieskończoność o liczby. Jeśli poda ci ujemną, to użyj break, aby zakończyć pętle.
        /// </summary>
        private void Zadanie4()
        {
            while (true)
            {
                Console.WriteLine("Podaj dowolną liczbę całkowitą: ");
                string input = Console.ReadLine()!;//operator pewności*
                /*
                    *Daje to znać kompilatorowi, że tu nie pojawi się null. W tym przypadku nawet jak się pojawi to, zapyta jeszcze raz, bo tak jest skonstruowany program.
                    Działanie to usuwa warning, który wyrzuca nam Visual Studio
                 */

                if (int.TryParse(input, out int value)) //spróbuj przeparsować na int. jeśli się uda zwróć tą wartość to wrzuć ją do zmiennej value
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Przerwanie pętli");
                        break;
                    }
                }
            }
        }

        private void Zadanie5()
        {
            Console.WriteLine("Podaj wielkość tablicy: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Zadanie5();
            }

            if (int.TryParse(input, out int n))
            {
                double[] tabDouble = LosujTabliceDouble(n, 1, 10);

                Console.WriteLine("Twoja tablica to: "); //pokaż wylosowaną tablicę n-elementową
                foreach (int element in tabDouble)//**
                {
                    Console.Write(element + "\t");
                }

                BubbleSort(tabDouble);

                Console.WriteLine("\n Twoja posortowana tablica to: "); //wynik
                foreach (int element in tabDouble)//**
                {
                    Console.Write(element + "\t");
                }

                /*
                    ** Czy elementy mogą być typu dobule, a wyświetlać jako inty? Czy jest to jakiś problem?
                 
                 */


            }

        }

        /// <summary>
        /// Sortowanie bąbelkowe
        /// </summary>
        private void BubbleSort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }

}