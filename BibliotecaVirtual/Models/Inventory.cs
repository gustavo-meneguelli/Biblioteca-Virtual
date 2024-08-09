namespace BibliotecaVirtual.Models
{
    internal class Inventory
    {
        private Dictionary<int, Book> BookList { get; set; }

        public Inventory()
        {
            BookList = new Dictionary<int, Book>
            {
                { 1, new Book("It Ends with Us", "Colleen Hoover", 29.90m) },
                { 2, new Book("O Homem mais Rico da Babilônia", "George S. Clason", 19.90m) },
                { 3, new Book("A Sutil Arte de Ligar o Foda-se", "Mark Manson", 24.90m) },
                { 4, new Book("O Milagre da Manhã", "Hal Elrod", 22.90m) },
                { 5, new Book("Do Mil ao Milhão. Sem Cortar o Cafezinho", "Thiago Nigro", 34.90m) },
                { 6, new Book("A Revolução dos Bichos", "George Orwell", 18.90m) },
                { 7, new Book("Harry Potter e a Pedra Filosofal", "J.K. Rowling", 39.90m) },
                { 8, new Book("O Poder do Hábito", "Charles Duhigg", 32.90m) },
                { 9, new Book("A Garota do Lago", "Charlie Donlea", 27.90m) },
                { 10, new Book("1984", "George Orwell", 25.90m) }
            };
        }

        public Dictionary<int, Book> GetBookList() => BookList;
    }
}
