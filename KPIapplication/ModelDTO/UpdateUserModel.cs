namespace KPIapplication.ModelDTO
{
    public class UpdateUserModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string Password { get; set; } = "";
        public DateTime Birthday { get; set; }
    }
}
