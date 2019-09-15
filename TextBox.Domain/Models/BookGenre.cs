using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class BookGenres
    {
        public int Id { get; set; }
        public List<Genre> BookGenress {get; set;} 
    }
}