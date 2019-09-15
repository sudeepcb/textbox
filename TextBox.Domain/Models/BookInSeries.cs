using System.Collections.Generic;

namespace TextBox.Domain.Models
{
  public class BookInSeries
  {
    public int Id { get; set; }
    public Series Series { get; set; }
    public List<Book> Books { get; set; }
    
  }
}