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
      if (i == 1)
      {SearchGenre(param);}
      else if(i == 2)
      {SearchAuthor(param);}
      else if(i==3)
      {SearchSeries(param);}
    }

    public void SearchGenre(string name)
    {
      library= new List<Book>();
      
      foreach(var g in _db.Genres.ToList())
      {
        if(g.GenreName.ToLower()==name.ToLower())
        {
          foreach(var bg in _db.BooksGenres.ToList())
          {
            if (g.Id == bg.GenreId)
            {  
              foreach(var b in _db.Books)
              {
                if (bg.BookId == b.Id)
                {library.Add(b);}
              }
            }
          }
        }
      }
    }

    public void SearchAuthor(string name)
    { 
      library= new List<Book>();
      
      foreach(var a in _db.Authors.ToList())
      { if(a.FirstName.ToLower()==name.ToLower())
        {
          foreach(var ba in _db.BooksAuthors.ToList())
              if (ba.Authors.Id == a.Id)
              {foreach (var b in _db.Books.ToList())
              if(b.Id==ba.BookId)
              {library.Add(b);}}
        }
      }
    }
    public void SearchSeries(string name)
    {
      library= new List<Book>();
      
      foreach(var s in _db.Seriess.ToList())
      {
        if(s.SeriesName.ToLower()==name.ToLower())
        {
          foreach(var bs in _db.BookInSeries.ToList())
          {
            if (s.Id == bs.SeriesId)
            {  
              foreach(var b in _db.Books)
              {
                if (bs.BookId == b.Id)
                {library.Add(b);}
              }
            }
          }
        }
      }
    }
    //---------------------------------------------------------------------
    public void Home(string filterName, int index)
    {
      setSearchLists();
      SearchLib(filterName,index);
    }
  }
}