using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class BookSeries
    {
        public int BookId {get; set;} 
        public int SeriesId {get; set;} 
        public Book Books {get; set;} 
        public Series Series {get; set;}
    }
}