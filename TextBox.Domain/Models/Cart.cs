namespace TextBox.Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Book> BooksInCart { get; set; }
        public public decimal TotalCost { get; set; }
    }
}