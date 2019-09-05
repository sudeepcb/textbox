namespace TextBox.Domain.Models
{
    public class Recomendation
    {
        public int Id { get; set; }
        public List<Book> RecommendedBooks { get; set; }
    }
}