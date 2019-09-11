
using TextBox.Domain.Models;

namespace TextBox.MVCClient.ViewModels
{
  public class BookPageVM
  { 
       public Book book { get; set; }
       public Genre Genre { get; set; }
       public List<Books> allBooks { get; set; }
       public List<Genre> allGenres { get; set; }

       public List<Author> allAuthors { get; set; }
       public List<string> allSeries { get; set; }

    }
}