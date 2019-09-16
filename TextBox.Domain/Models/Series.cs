using System.Collections.Generic;

namespace TextBox.Domain.Models
{
  public class Series
  {
    public int Id { get; set; }
    public string SeriesName {get; set;}
    public virtual ICollection<BookSeries> BooksInSeries { get; set; }
  }
}