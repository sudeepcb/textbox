using System.Collections.Generic;
using System.Linq;
using TextBox.Data;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.Models
{
  public class CartModel
  {
    public TextBoxDBContext _db = new TextBoxDBContext();
    public static BooksOnOrder userCart {get; set;} 
    public static Order Order {get; set;}
    public List<Genre> allGenres {get; set; }
    public List<Series> allSeries {get; set; } 
    public List<Author> allAuthors { get; set; }
    
    public void bookToCart(int filter)
    {
      
      allGenres = _db.Genres.ToList();
      allAuthors = _db.Authors.ToList();
      allSeries = _db.Seriess.ToList();
      allAuthors = _db.Authors.ToList();
      System.Console.WriteLine("\n\n\n\n\n"+filter+"\n\n\n\n\n");
      
      if (userCart==null)
      {
        Order = new Order();
      }

       foreach (var b in _db.Books.ToList())
       {
           if (b.Id==filter)
         {
            System.Console.WriteLine("\n\n\n\n\n"+b.Title+"\n\n\n\n\n");
            userCart = new BooksOnOrder();
            userCart.OrderId=Order.Id;
            userCart.BookId=b.Id;
            userCart.Order=Order;
            userCart.Books=b;
            _db.BooksOnOrder.Add(userCart);
        }
      }
    }
  }
}