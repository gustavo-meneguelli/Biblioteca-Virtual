
namespace BibliotecaVirtual.Models
{
    internal class CreditCardPayment : Payment
    {
        private string CardHolder { get; }
        private int CardNumber { get; }
        private decimal CardAmount { get; }
        public CreditCardPayment(User user) : base(user)
        {
            CardHolder = user.Name;
            CardAmount = user.GetCreditCardBalance();
            CardNumber = 123456789;
        }

        public override bool Pay(decimal value)
        {
            return CheckBalance(value);
        }

        protected override bool CheckBalance(decimal value)
        {
            return CardAmount >= value;
        }
    }
}
