using System.Collections.Generic;
using System.Linq;
using TextBox.Data;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.Models
{
  public class LibraryModel
  {
    public TextBoxDBContext _db = new TextBoxDBContext();
    public List<Book> library {get; set;}
    public List<Genre> allGenres {get; set; }
    public List<Series> allSeries {get; set; } 
    public List<Author> allAuthors { get; set; }
    public List<BookAuthors> allBookAuthors {get; set;}
    
    public List<Book> dbList()
    {
      return (_db.Books.ToList());
    }

    public void setLists()
    {
      library = _db.Books.ToList();
      allGenres = _db.Genres.ToList();
      allAuthors = _db.Authors.ToList();
      allSeries = _db.Seriess.ToList();
      allBookAuthors = _db.BooksAuthors.ToList();
    }
    public void SortLib(List<Book> library,int i)
    {
      if(i==1)
      {library = library.OrderBy(l=>l.Title).ToList();}
      if(i==2)
      {library=library.OrderByDescending(b => b.Title).ToList();}
      {}
      if(i==3)
      {library=library.OrderBy(b => b.Cost).ToList();}
      if(i==4)
      {library=library.OrderByDescending(b => b.Cost).ToList();}
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
            if (a.Authors.FirstName == "name" || a.Authors.LastName == "name")
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
            if (a.Authors.FirstName == "name" || a.Authors.LastName == "name")
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
            if (a.Authors.FirstName == "name" || a.Authors.LastName == "name")
            {returnLib.Add(b);}
      }
      return returnLib;
    }


  }
}