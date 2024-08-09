using BibliotecaVirtual.Models;

namespace BibliotecaVirtual.Interfaces
{
    internal class UserInterface
    {
        //Exibe o Menu Principal retornando o indíce escolhido pelo usuário
        public int MainMenu()
        {
            return MenuGenerator("Menu Principal", new List<string> { "Comprar Livro", "Adicionar Livro", "Remover Livro", "Exibir Compras" });
        }

        //Exibe  os Livros que estão a venda, retornando o indíce escolhido pelo usuário.
        public int BuyBookMenu()
        {
            Inventory inventory = new Inventory();
            List<string> bookList = inventory.GetBookList().Values.Select(x => x.Title).ToList();

            return MenuGenerator("Comprar Livro", bookList);
        }
        //Método cria um menu automático
        //Parâmetros => menuTitle = Titulo do Menu criado, menuItens = Lista com cada opção do menu 
        private int MenuGenerator(string menuTitle, List<string> menuItens)
        {
            int userChoice;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("----------------------------");
                Console.WriteLine($"    {menuTitle}            ");
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
