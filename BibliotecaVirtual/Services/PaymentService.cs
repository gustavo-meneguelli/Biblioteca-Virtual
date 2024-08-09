using BibliotecaVirtual.Models;

namespace BibliotecaVirtual.Services
{
    internal class PaymentService
    {
        private readonly Payment _payment;
        private readonly Book _book;
        public PaymentService(Payment payment, Book book)
        {
            _payment = payment;
            _book = book;
        }

        public void Pay()
        {
            if (_payment.Pay(_book.Price))
                Console.WriteLine("Pagamento efetuado com sucesso.");
            else
                Console.WriteLine("Pagamento não efetuado por falta de saldo.");

            Console.ReadKey();
        }
    }
}
