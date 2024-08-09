using System.Runtime.InteropServices.Marshalling;

namespace BibliotecaVirtual.Models
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public decimal Price { get; }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public void Details()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Titulo: {Title}");
            Console.WriteLine($"Autor: {Author}");
            Console.WriteLine($"Valor R${Price}");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
