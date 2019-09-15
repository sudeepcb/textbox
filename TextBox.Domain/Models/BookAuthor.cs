using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public List<Author> Authors {get; set;} 
    }
}