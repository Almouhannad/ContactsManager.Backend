namespace ContactsManager.API
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string Phone { get; set; } = null!;
        public bool Favorite { get; set; }
    }
}
