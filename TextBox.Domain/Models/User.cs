using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Cart CurrentCart { get; set; }
        public virtual Order Order { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
        public virtual ICollection<Book> BooksInOrder { get; set; }

        public User()
        {
          List<Order> OrderHistory = new List<Order>();
        }
    }
}