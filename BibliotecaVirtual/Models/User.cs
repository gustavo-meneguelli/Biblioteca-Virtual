namespace BibliotecaVirtual.Models
{
    internal class User
    {
        public string Name { get; set; }
        private int Id { get; set; }
        private decimal CreditCardBalance { get; set; }

        public User(string name)
        {
            Name = name;
            Id = -1;
            CreditCardBalance = 00;
        }
        public void Details() => Console.WriteLine($"Logged user: {Name}");
        public decimal GetCreditCardBalance() => CreditCardBalance;
    }
}
