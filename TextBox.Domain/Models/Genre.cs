using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public virtual ICollection<BookGenres> BookGenres { get; set; }
    }
}