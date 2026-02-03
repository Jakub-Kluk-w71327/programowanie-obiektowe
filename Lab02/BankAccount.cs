namespace programowanie_obiektowe
{
    internal class BankAccount
    {
        //pola
        private string? owner; // ? oznacza, że zmienna może przyjąć wartość null. Takie podejście dodatkowo eliminuje warning: Non-nullable field 'owner' must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring the field as nullable.
        private decimal amount;

        //właściwości (properties)
        public decimal Amount
        {
            get { return amount; }
            private set { amount = value; } // Saldo jest chronione (hermetyzacja = kontrola dostępu). Nie da się zrobić account.Amount = 999999 w klasie Program.cs;

        }
        public string Owner { 
            get {
                if (owner == null) 
                    throw new ArgumentException("Pole 'owner' nie może być null"); //eliminuje to waring: Possible null reference return.
                return owner; 
            } 
            set {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Pole 'właścicel' nie jest wypełnione poprawnie.");
                owner = value; 
            }

        }


        //metody
        public void Deposit(decimal value)
        {
            amount += value;
        }

        public void Withdrawal(decimal value)
        {
            if (value < amount)
                amount -= value;
            else
                throw new ArgumentException("Kwota wypłaty jest większa od środków posiadanych na rachunku bankowym.");
        }

        //konstruktor - służy do ustawienia początkowego stanu obiektu
        public BankAccount(string owner, decimal amount)
        {
            this.Owner = owner;
            this.Amount = amount;
        }
    }

}
