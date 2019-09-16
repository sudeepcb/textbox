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
    public int filtertype;
    
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
    public void setSearchLists()
    {
      allGenres = _db.Genres.ToList();
      allAuthors = _db.Authors.ToList();
      allSeries = _db.Seriess.ToList();
      allBookAuthors = _db.BooksAuthors.ToList();
    }
    //----------------------------------------------------------------
    public void SortLib(int i)
    {
      if(i==1)
      {library = library.OrderBy(l=>l.Title).ToList();}
      // {
      //   library.Sort(delegate(Book x, Book y)
      //     {return x.Title.CompareTo(y.Title);}       
      // );}
      if(i==2)
      {library=library.OrderByDescending(b => b.Title).ToList();}
      if(i==3)
      {library=library.OrderBy(b => b.Cost).ToList();}
      if(i==4)
      {library=library.OrderByDescending(b => b.Cost).ToList();}
    }
    //-------------------------------------------------------------SEARCH-----------------------------------------------------
    public void SearchLib (string param, int i)
    {
      System.Console.WriteLine("\n\n\n\n\n" +param+i+" still going well \n\n\n\n\n");
      if (i == 1)
      {SearchGenre(param);}
      else if(i == 2)
      {SearchAuthor(param);}
      else if(i==3)
      {SearchSeries(param);}
    }

    public void SearchGenre(string name)
    {
      System.Console.WriteLine("\n\n\n\n\n We made it genre! \n\n\n\n\n");
      
      System.Console.WriteLine("\n\n\n\n\n"+name.ToLower()+"\n\n\n\n\n");
      foreach(var a in _db.Authors.ToList())
      {
        System.Console.WriteLine("\n\n\n\n\n"+a.LastName.ToLower()+"\n\n\n\n\n");
        if(a.LastName.ToLower()==name.ToLower())
        {
          foreach(var ba in _db.BooksAuthors)
              if (ba.Authors.Id == a.Id)
              {library.Add(ba.Books);}
        }
      }
    }

    public void SearchAuthor(string name)
    { library= new List<Book>();
      System.Console.WriteLine("\n\n\n\n\n We made it "+name+"! \n\n\n\n\n");
      
      foreach(var a in _db.Authors.ToList())
      { if(a.FirstName.ToLower()==name.ToLower())
        {
          foreach(var ba in _db.BooksAuthors.ToList())
              if (ba.Authors.Id == a.Id)
              {foreach (var b in _db.Books.ToList())
              if(b.Id==ba.BookId)
              {System.Console.WriteLine("\n\n\n\n\n "+b.Title+"! \n\n\n\n\n");
                library.Add(b);}}
        }
      }
    }
    public void SearchSeries(string name)
    {
      foreach(var s in _db.Seriess.ToList())
      {
        System.Console.WriteLine("\n\n\n\n\n We made it series! \n\n\n\n\n");
      
        if(s.SeriesName.ToLower()==name.ToLower())
        {
          // foreach(var bg in _db..ToList())
          //     if (bg.GenreId == s.Id)
          //     {library.Add(ba.Books);}
        }
      }
    }
  }
}