namespace TextBox.Domain.Models
{
  public class Series
  {
    public int Id { get; set; }
    public string BookSeries { get; set; }

    public int BookId {get; set;}
    public Book Book {get; set;}
  }
}