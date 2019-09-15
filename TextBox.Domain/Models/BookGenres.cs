using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class BookGenres
    {
        public int BookId {get; set;} 
        public int GenreId {get; set;} 
        public Book Books {get; set;} 
        public Genre Genres {get; set;}
    }
}