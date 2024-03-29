using System.Collections.Generic;
using System.Linq;
using TextBox.Data;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.Models
{
  public class CartModel
  {
    private TextBoxDBContext _db = new TextBoxDBContext();
    public static BooksOnOrder userCart {get; set;} 
    public static Order userOrder {get; set;}
    public List<Book> booksList {get;set;}
    public List<Genre> allGenres {get; set; }
    public List<Series> allSeries {get; set; } 
    public List<Author> allAuthors { get; set; }
    public decimal TotalCost {get; set;}
    
    public void bookToCart(int filter)
    {
      
      allGenres = _db.Genres.ToList();
      allAuthors = _db.Authors.ToList();
      allSeries = _db.Seriess.ToList();
      

      System.Console.WriteLine("\n\n\n\n\nThis is what your want: "+filter+"\n\n\n\n\n");
      
      // if (booksList==null)
      // {
      //   userCart = new BooksOnOrder();
      //   //userOrder.UserId=1;
      //   foreach (var u in _db.Users.ToList())
      //   {
      //     if (u.Id==2)
      //     {
      //       userCart.OrderId=u.Order.Id;
      //       userOrder=u.Order;
      //     }
      //   }
      //   TotalCost = 0.0;
      // }

       foreach (var b in _db.Books.ToList())
       {
           if (b.Id==filter)
        {
          System.Console.WriteLine("\n\n\n\n\n"+b.Title+"\n\n\n\n\n");
          userCart = new BooksOnOrder();
          userCart.OrderId=1;
          userCart.BookId=b.Id;
          userCart.Order=userOrder;
          userCart.Books=b;
          System.Console.WriteLine("\n\n\n\n\n"+userCart.BookId+"\n\n\n\n\n");
          System.Console.WriteLine("\n\n\n\n\n"+userCart.OrderId+"\n\n\n\n\n");
          // userCart.OrderId=userOrder.Id;
          userCart.BookId=b.Id;
          //userCart.Order.TotalCost=currentcost()+b.Cost;
          _db.BooksOnOrder.Add(userCart);
          _db.SaveChanges();
          setBookList();
          TotalCost=currentcost();
        }
      }
    }
    
    public void setBookList()
      {
        booksList = new List<Book>();
        
      foreach (var bO in _db.BooksOnOrder.ToList())
        {
          foreach (var b in _db.Books.ToList())
          {
            if (bO.BookId==b.Id)
            {booksList.Add(b);}
          }
        }
      }
      public decimal currentcost()
      {
        decimal cost=0.0m;
        foreach (var o in _db.BooksOnOrder.ToList())
        {
         cost=cost+o.Books.Cost;
          
        }
        System.Console.WriteLine("printer here");
        System.Console.WriteLine(cost);
        return cost;
      }
  }
}