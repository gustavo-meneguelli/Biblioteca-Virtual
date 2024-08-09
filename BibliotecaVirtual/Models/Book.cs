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
    }
}
