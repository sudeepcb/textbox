using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public bool OrderPaid { get; set; }
        public decimal TotalCost { get; set; }
        public int UserId {get; set;}
        public User User {get; set;}
        public virtual ICollection<BooksOnOrder> BooksOnOrder { get; set; }
    
        Order()
        {
          List<Book> BooksOnOrder = new List<Book>();
        }
    }
}