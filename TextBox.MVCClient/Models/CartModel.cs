using System.Collections.Generic;
using System.Linq;
using TextBox.Data;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.Models
{
  public class CartModel
  {
    public TextBoxDBContext _db = new TextBoxDBContext();
    public Book bookCart {get; set;}
    public Cart userCart {get; set;}
    public List<Genre> allGenres {get; set; }
    public List<Series> allSeries {get; set; } 
    public List<Author> allAuthors { get; set; }
    
    public void bookToCart(int filter)
    {
      bookCart = new Book();
      //userCart = new Cart();
      allGenres = _db.Genres.ToList();
      allAuthors = _db.Authors.ToList();
      allSeries = _db.Seriess.ToList();
      allAuthors = _db.Authors.ToList();

      // foreach (var b in _db.Books.ToList())
      // {
        
      //   if (b.Id==filter)
      //   {
      //     System.Console.WriteLine("SHOULD PRINT HERE");
      //     System.Console.WriteLine(bookreturn.Id);
      //     System.Console.WriteLine(filter);
      //     bookreturn=b;
      //     foreach (var ba in _db.BooksAuthors.ToList())
      //     {
      //       if (b.Id==ba.BookId)
      //       {
      //         authorreturn=ba.Authors;
      //       }
      //     }
      //   }
      // }
    }
  }
}