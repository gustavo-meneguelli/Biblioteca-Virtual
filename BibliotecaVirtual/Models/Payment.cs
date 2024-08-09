namespace BibliotecaVirtual.Models
{
    internal abstract class Payment
    {
        public DateTime PaymentDate { get; }
        protected Payment(User user)
        {
            PaymentDate = DateTime.Now;
        }
        public abstract bool Pay(decimal value);
        protected abstract bool CheckBalance(decimal value);
    }
}
