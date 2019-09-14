using System.Collections.Generic;

namespace TextBox.Domain.Models
{
  public class Series
  {
    public int Id { get; set; }
    public string SeriesName { get; set; }
    public List<Book> BooksInSeries { get; set; }
    public int BookId {get; set;}
    public Book Book {get; set;}
  }
}