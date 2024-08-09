using BibliotecaVirtual.Models;

namespace BibliotecaVirtual.Services
{
    internal class MenuService
    {
        private readonly Inventory _inventory;
        private readonly User _user;
        public MenuService(User user, Inventory inventory)
        {
            _inventory = inventory;
            _user = user;
        }

        public void Show()
        {
            int homeMenuIndex = HomeMenu();

            switch (homeMenuIndex)
            {
                case 1:
                    {
                        ShowAvailableBooks();
                        break;
                    }
            }
        }

        //Exibe o Menu Principal retornando o indíce escolhido pelo usuário
        private int HomeMenu()
        {
            return GenerateMenu("Menu Principal", new List<string> { "Livros Disponíveis", "Adicionar Livro", "Remover Livro", "Exibir Compras" });
        }

        //Exibe  os Livros que estão a venda, retornando o indíce escolhido pelo usuário.
        private void BuyBookMenu(Book book)
        {
            int indexPayment = GenerateMenu(
                $"Comprar: {book.Title}\n" +
                $"Valor R${book.Price}", new List<string> { "Cartão" });

            switch (indexPayment)
            {
                case 1:
                    //Pagamento Cartão
                    new PaymentService(new CreditCardPayment(_user), book).Pay();
                    break;
            }
        }

        //Exibe os livros disponíveis
        private void ShowAvailableBooks()
        {
            List<string> bookList = _inventory.GetBookList().Values.Select(x => x.Title).ToList();

            int indexChosenBook =  GenerateMenu("Livros Disponíveis", bookList);

            Book bookChoice = _inventory.GetBookAtIndex(indexChosenBook);

            MenuChosenBook(bookChoice);

        }

        //Exibe o menu do livro escolhido
        private void MenuChosenBook(Book book)
        {
            int indexUserChoice = GenerateMenu($"Livro: {book.Title}", new List<string> { "Exibir Detalhes", "Comprar Livro" });

            switch (indexUserChoice)
            {
                case 1:
                    book.Details();
                    break;
                case 2:
                    BuyBookMenu(book);
                    break;
            }
        }

        //Método cria um menu automático
        //Parâmetros => menuTitle = Titulo do Menu criado, menuItens = Lista com cada opção do menu 
        private int GenerateMenu(string menuTitle, List<string> menuItens)
        {
            int userChoice;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("----------------------------");
                Console.WriteLine($"{menuTitle}                ");
                Console.WriteLine("----------------------------");

                for (int i = 0; i < menuItens.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menuItens[i]}");
                }
                Console.WriteLine("----------------------------");
                Console.Write("Digite a opção disponível: ");

                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("Error. O valor digitado precisa ser numérico.");
                }
                else if (userChoice < 0 || userChoice > menuItens.Count)
                {
                    Console.WriteLine($"Erro. O valor digitado precisa estar entre 0 e {menuItens.Count}");
                }
                else
                {
                    break;
                }
                Console.ReadKey();
            }
            return userChoice;
        }
    }
}
