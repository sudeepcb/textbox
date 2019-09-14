using System.Collections.Generic;
using TextBox.Data;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.Models
{
    public class BookInsertion
    {
      private TextBoxDBContext _db = new TextBoxDBContext();
      public void AddBookToDB( Book b,Author a,Genre g)
      {
          if(!AuthorInDB() && !GenreInDB())
          {
            b.BookAuthors  = new List<Author>();
            b.BookGenres = new List<Genre>();

            b.BookAuthors.Add(a);
            b.BookGenres.Add(g);

            _db.Books.Add(b);
            _db.SaveChanges();
          }          
      }

      public bool AuthorInDB()
      {
        return true;
      }
      public bool GenreInDB()
      {
        return false;
      }
    }
}