using System;
using System.Collections.Generic;

namespace TextBox.Domain.Models
{
    public class Book
    {
      public int Id { get; set; }
      public string Title { get; set; }
      public string Publisher { get; set; }
      public string BookCover { get; set; }
      public string Synopsis { get; set; }
      public virtual ICollection<BookAuthors> BookAuthors { get; set; }
      public virtual ICollection<BookGenres> BookGenres { get; set; }
      public decimal Cost { get; set; }
      public string ISBN { get; set; }
      public int Pages { get; set; }
      public int AmountSold { get; set; }
      public DateTime ReleaseDate { get; set; }
      public double AverageRating { get; set; }
      public virtual ICollection<BookReviews> userReviews { get; set; }

      public Book()
      {
        List<Author> BookAuthors = new List<Author>();
        List<Genre> BookGenres = new List<Genre>();
        List<Review> userReviews = new List<Review>();
        
      }
    }
}