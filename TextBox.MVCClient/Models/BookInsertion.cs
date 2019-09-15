using System.Collections.Generic;
using System.Linq;
using TextBox.Data;
using TextBox.Domain.Models;

namespace TextBox.MVCClient.Models
{
    public class BookInsertion
    {
      private TextBoxDBContext _db = new TextBoxDBContext();
      public void AddBookToDB( Book b,Author a,Genre g)
      {
          //b.BookAuthors  = new List<Author>();
          //b.BookGenres = new List<Genre>();

          // if(!AuthorInDB(a) && !GenreInDB(g))
          // {

          //   _db.Authors.Add(a);
          //   _db.Genres.Add(g);

          //   _db.Books.Add(b);
          //   _db.SaveChanges();
          // }
          // if(AuthorInDB(a) && !GenreInDB(g))
          // {
          //   b.BookAuthors.Find(author=>author.Id == a.Id);
          //   b.BookGenres.Add(g);

          //   _db.Books.Add(b);
          //   _db.SaveChanges();
          // }
          // else
          // {

          // }          
      }

      public bool AuthorInDB(Author author)
      {
        if((_db.Authors.Any(a=>a.FirstName == author.FirstName)) && (_db.Authors.Any(a=>a.LastName == author.LastName)))
        {
          return true;
        }

        return false;
      }
      public bool GenreInDB(Genre genre)
      {
        if(_db.Genres.Any(g=>g.GenreName == genre.GenreName))
        {
          return true;
        }

        return false;
      }
    }
}