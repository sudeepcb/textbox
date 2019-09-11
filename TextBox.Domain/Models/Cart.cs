using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Book> BooksInCart { get; set; }
        public decimal TotalCost { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}