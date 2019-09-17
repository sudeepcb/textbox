using System.Collections.Generic;
using System.Linq;
using TextBox.Data;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.Models
{
  public class BookModel
  {
    public TextBoxDBContext _db = new TextBoxDBContext();
    public Book bookreturn {get; set;}
    public Author authorreturn {get; set;}
    public List<Genre> allGenres {get; set; }
    public List<Series> allSeries {get; set; } 
    public List<Author> allAuthors { get; set; }
    
    public void returnBook(int filter)
    {
      allGenres = _db.Genres.ToList();
      allAuthors = _db.Authors.ToList();
      allSeries = _db.Seriess.ToList();
      allAuthors = _db.Authors.ToList();

      foreach (var b in _db.Books.ToList())
      {
        bookreturn = new Book();
        authorreturn = new Author();
        
        if (b.Id==filter)
        {
          bookreturn=b;
          foreach (var ba in _db.BooksAuthors.ToList())
          {
            if (b.Id==ba.BookId)
            {
              authorreturn=ba.Authors;
            }
          }
        }
      }
    }
  }
}