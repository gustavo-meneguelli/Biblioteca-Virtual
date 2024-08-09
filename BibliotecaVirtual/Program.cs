using BibliotecaVirtual.Models;
using BibliotecaVirtual.Services;

namespace BibliotecaVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            User firstUser = new User("Gustavo");

            MenuService menuService = new MenuService(firstUser, inventory);

            menuService.Show();

        }
    }
}
