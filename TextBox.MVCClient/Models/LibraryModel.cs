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
      {return library;}//.OrderBy(l => l.BookAuthors.OrderBy(b => b.LastName));}
      if(i==1)
      {return SortDes(library);}
      if(i==2)
      {return SortPrice(library);}
      else
      {return library;}
    }
    //-----------------
    // public List<Book> SortPrice(List<Book> library, string para)
    // {
    //   library.OrderBy(l => l.para);
    //   return library;
    // }
    //------------------
    //-------------------------------------------------------------SEARCH-----------------------------------------------------
    public List<Book> Sort (List<Book> library, int i)//, string name)
    {
      return library;
    }
    public List<Book> SortAsc(List<Book> library)
    {
      library.OrderBy(b => b.Title);
      return library;
    }
    public List<Book> SortDes(List<Book> library)
    {
      library.OrderByDescending(b => b.Title);
      return library;
    }
    public List<Book> SortPrice(List<Book> library)
    {
      library.OrderBy(b => b.Cost);
      return library;
    }
    public List<Book> SortPriceDes(List<Book> library)
    {
      library.OrderByDescending(b => b.Cost);
      return library;
    }
    public List<Book> SortNew(List<Book> library)
    {
      library.OrderBy(b => b.ReleaseDate);
      return library;
    }
    public List<Book> SortNewDes(List<Book> library)
    {
      library.OrderByDescending(b => b.ReleaseDate.Date);
      return library;
    }
//---------------------------------------------------------------------------------------------------------------------------
    //public List<Book> 
//-------------------------------------------------------------SEARCH-BAR----------------------------------------------------
//STIRNGDOTSPLIT
    public List<Book> Search (List<Book> library, int i)//, string name)
    {
        return library;
    }
    public List<Book> SearchAuthor(List<Book> library, string name)
    {
      List<Book> returnLib = new List<Book>{};
      foreach(var b in library)
      {
        foreach(var a in b.BookAuthors)
            if (a.FirstName == "name" || a.LastName == "name")
            {returnLib.Add(b);}
      }
      return returnLib;
    }

    public List<Book> SearchGenre(List<Book> library, string name)
    {
      List<Book> returnLib = new List<Book>{};
      foreach(var b in library)
      {
        foreach(var a in b.BookAuthors)
            if (a.FirstName == "name" || a.LastName == "name")
            {returnLib.Add(b);}
      }
      return returnLib;
    }
    public List<Book> SearchSeries(List<Book> library, string name)
    {
      List<Book> returnLib = new List<Book>{};
      foreach(var b in library)
      {
        foreach(var a in b.BookAuthors)
            if (a.FirstName == "name" || a.LastName == "name")
            {returnLib.Add(b);}
      }
      return returnLib;
    }


  }
}