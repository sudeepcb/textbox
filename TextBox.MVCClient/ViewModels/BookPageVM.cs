using System.Collections.Generic;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.ViewModels
{
  public class BookPageVM
  { 
       public Book book { get; set; }
       public Genre Genre { get; set; }
       public List<Book> allBooks { get; set; }
       public List<Genre> allGenres { get; set; }
      
       public List<Book> certainBooks { get; set; }
       public List<Author> allAuthors { get; set; }
       public List<string> allSeries { get; set; }

    }
}