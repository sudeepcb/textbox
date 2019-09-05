namespace TextBox.Domain.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Cart CurrentCart { get; set; }
        public List<Order> OrderHistory { get; set; }
    }
}