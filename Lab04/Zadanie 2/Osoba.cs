namespace Lab03_ćwiczenia
{
    internal abstract class Osoba
    {
        //fields
        protected string? firstName;
        protected string? lastName;
        protected string? pesel;

        //methods
        public void SetFirstName(string? firstName)
        {
            this.firstName = firstName;
        }
        public void SetLastName(string? lastName)
        {
            this.lastName = lastName;
        }
        public void SetPesel(string? pesel)
        {
            this.pesel = pesel;
        }
        public int GetAge()
        {
            int result = 0;

            if (pesel != null)
            {
                List<char> chars = new List<char>(pesel);

                string month = "" + chars[2] + chars[3];

                int monthInt = int.Parse(month);

                if (monthInt > 12)
                {
                    monthInt -= 20;

                    string year = "20" + chars[0] + chars[1];
                    int yearInt = int.Parse(year);

                    string day = "" + chars[4] + chars[5];
                    int dayInt = int.Parse(day);

                    DateOnly today = DateOnly.FromDateTime(DateTime.Today);
                    int age = today.Year - yearInt;
                    
                    if(today < new DateOnly(today.Year, monthInt, dayInt))
                    {
                        age--;
                    }
                    result = age;
                }
                else
                {
                    string year = "19" + chars[0] + chars[1];
                    int yearInt = int.Parse(year);

                    string day = "" + chars[4] + chars[5];
                    int dayInt = int.Parse(day);

                    DateOnly today = DateOnly.FromDateTime(DateTime.Today);
                    int age = today.Year - yearInt;

                    if (today < new DateOnly(today.Year, monthInt, dayInt))
                    {
                        age--;
                    }
                    result = age;
                }
            }
            return result;
        }
        public string GetGender() //Pozycja 10 (kobiety parzyste, mezczyzni nieparzyste)
        {
            string? result = "";

            if (pesel != null)
            {
                List<char> chars = new List<char>(pesel);
                string genderNumber = "" + chars[9];

                int genderNumberInt = int.Parse(genderNumber);

                if (genderNumberInt % 2 == 0)
                {
                    result = "kobieta";
                }
                else
                {
                    result = "mężczyzna";
                }
            }

            return result;
        }

        //-----------------------------------------------------------------------------

        public abstract void GetEducationInfo();
        public abstract void GetFullName();
        public abstract bool CanGoAloneToHome();
    }
}
