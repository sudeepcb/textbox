using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class BooksInCart
    {
        public int BookId {get; set;} 
        public int CartId {get; set;} 
        public Book Books {get; set;} 
        public Cart Cart {get; set;}
    }
}