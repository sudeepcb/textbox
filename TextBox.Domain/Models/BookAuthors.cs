using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class BookAuthors
    {
        public int BookId {get; set;} 
        public int AuthorId {get; set;} 
        public Book Books {get; set;} 
        public Author Authors {get; set;}
    }
}