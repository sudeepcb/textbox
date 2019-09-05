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
      public List<Author> BookAuthors { get; set; }
      public List<Genre> BookGenres { get; set; }
      public string  Series { get; set; }
      public decimal Cost { get; set; }
      public string ISBN { get; set; }
      public int Pages { get; set; }
      public int AmountSold { get; set; }
      public DateTime ReleaseDate { get; set; }
      public double AverageRating { get; set; }
      public List<Review> userReviews { get; set; }
    }
}