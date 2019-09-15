using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class BookReviews
    {
        public int BookId {get; set;} 
        public int ReviewId {get; set;} 
        public Book Books {get; set;} 
        public Review Review {get; set;}
    }
}