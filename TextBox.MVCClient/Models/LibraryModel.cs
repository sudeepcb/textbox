using System.Collections.Generic;
using System.Linq;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.Models
{
  public class LibraryModel
  {
    // public List<Book> OrderLibDynamic(List<Book> library, string description)
    // {
    //   var query = DbContext.Book
    //     .Select()
    //     .OrderBy(description);
    //   return library;
    // }
    public List<Book> SortLib(int i, List<Book> library)
    {
      if(i==0)
      {return SortAsc(library);}
      if(i==1)
      {return SortDes(library);}
      if(i==2)
      {return SortPrice(library);}
      else
      {return library;}
    }
    public List<Book> SortAsc(List<Book> library)
    {
      library.OrderBy(i => i);
      return library;
    }
    public List<Book> SortDes(List<Book> library)
    {
      library.OrderByDescending(i => i);
      return library;
    }
    public List<Book> SortPrice(List<Book> library)
    {
      library.OrderBy(l => l.Cost);
      return library;
    }
    public List<Book> SortPriceDes(List<Book> library)
    {
      library.OrderByDescending(l => l.Cost);
      return library;
    }
    public List<Book> SortNew(List<Book> library)
    {
      library.OrderBy(l => l.ReleaseDate);
      return library;
    }
    public List<Book> SortNewDes(List<Book> library)
    {
      library.OrderByDescending(l => l.ReleaseDate);
      return library;
    }

    public List<Book> SearchAuthor(int i, List<Book> library)
    {
      List<Book> returnLib = new List<Book>{};
      foreach(var b in library)
      {
        foreach(var a in b.BookAuthors.ToString())
            if (a == 'c')
            {returnLib.Add(b);}
      }
      return returnLib;
    }
  }
}