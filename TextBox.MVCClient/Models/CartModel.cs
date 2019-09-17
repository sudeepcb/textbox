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
    public static Order userOrder {get; set;}
    public List<Book> booksList {get;set;}
    public List<Genre> allGenres {get; set; }
    public List<Series> allSeries {get; set; } 
    public List<Author> allAuthors { get; set; }
    public double TotalCost {get; set;}
    
    public void bookToCart(int filter)
    {
      
      allGenres = _db.Genres.ToList();
      allAuthors = _db.Authors.ToList();
      allSeries = _db.Seriess.ToList();
      allAuthors = _db.Authors.ToList();
      setBookList();

      System.Console.WriteLine("\n\n\n\n\nThis is what your want: "+filter+"\n\n\n\n\n");
      
      if (userCart==null)
      {
        userOrder = new Order();
        userOrder.UserId=1;
        TotalCost = 0.0;
        _db.Orders.Add(userOrder);
      }

       foreach (var b in _db.Books.ToList())
       {
           if (b.Id==filter)
        {
          System.Console.WriteLine("\n\n\n\n\n"+b.Title+"\n\n\n\n\n");
          userCart = new BooksOnOrder();
          userCart.OrderId=userOrder.Id;
          userCart.BookId=b.Id;
          userCart.Order=userOrder;
          userCart.Books=b;
          userCart.Order.TotalCost=userCart.Order.TotalCost+b.Cost;
          _db.BooksOnOrder.Add(userCart);
          _db.SaveChanges();
        }
      }
    }
    public void setBookList()
      {
        
      foreach (var bO in _db.BooksOnOrder.ToList())
        {
          booksList.Add(bO.Books); 
        }
      }
  }
}