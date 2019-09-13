using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public List<Book> RecommendedBooks { get; set; }

        Recommendation()
        {
          List<Book> RecommendedBooks = new List<Book>();
        }
    }
}