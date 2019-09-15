using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class BooksOnOrder
    {
        public int BookId {get; set;} 
        public int OrderId {get; set;} 
        public Book Books {get; set;} 
        public Order Order {get; set;}
    }
}