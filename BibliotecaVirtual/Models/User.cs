namespace BibliotecaVirtual.Models
{
    internal class User
    {
        public string Name { get; set; }
        private int Id { get; set; }

        public User(string name)
        {
            Name = name;
            Id = -1;
        }
    }
}
