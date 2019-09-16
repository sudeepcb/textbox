using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TextBox.Domain.Models;
using TextBox.MVCClient.Controllers;
using TextBox.MVCClient.Models;
using Xunit;

namespace TextBox.Tests
{
    public class HomeControllerTest
    {
      [Fact]
      public void TestIndex()
      {
        var controllerreview = new HomeController();
        var viewreturn = controllerreview.Index();
        
        Assert.NotNull(viewreturn);
        Assert.IsType<ViewResult>(viewreturn);    
      }

      [Fact]
      public void TestLogin()
      {
        var controllerreview = new HomeController();
        var viewreturn = controllerreview.Login();
        
        Assert.NotNull(viewreturn);
        Assert.IsType<ViewResult>(viewreturn);
      }

      [Fact]
      public void TestRegister()
      {
        var controllerreview = new HomeController();
        var viewreturn = controllerreview.Register();
        
        Assert.NotNull(viewreturn);
        Assert.IsType<ViewResult>(viewreturn);
      }

      [Fact]
      public void TestPrivacy()
      {
        var controllerreview = new HomeController();
        var viewreturn = controllerreview.Privacy();
        
        Assert.NotNull(viewreturn);
        Assert.IsType<ViewResult>(viewreturn);
      }
    }

    public class TestLibraryModelSorts
    {

        [Fact]
        public void TestLibrarySortAsc()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Title = "A";
          b2.Title = "B";

          List<Book> Expectedlib = new List<Book>();
          lm.library = new List<Book>();

          Expectedlib.Add(b1);
          Expectedlib.Add(b2);

          lm.library.Add(b2);
          lm.library.Add(b1);
          

          lm.SortLib(1);

          Assert.NotNull(lm.library);
          Assert.IsType<List<Book>>(lm.library);
          Assert.True(Expectedlib.Any() == lm.library.Any());
        }

        [Fact]
        public void TestLibrarySortDes()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Title = "A";
          b2.Title = "B";

          List<Book> Expectedlib = new List<Book>();
          lm.library = new List<Book>();

          Expectedlib.Add(b2);
          Expectedlib.Add(b1);

          lm.library.Add(b1);
          lm.library.Add(b2);

          lm.SortLib(2);

          Assert.NotNull(lm.library);
          Assert.IsType<List<Book>>(lm.library);
          Assert.True(Expectedlib.Any() == lm.library.Any());
        }

        [Fact]
        public void TestLibrarySortPrice()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Cost = 4.00m;
          b2.Cost = 5.00m;

          List<Book> Expectedlib = new List<Book>();
          lm.library = new List<Book>();

          Expectedlib.Add(b2);
          Expectedlib.Add(b1);

          lm.library.Add(b1);
          lm.library.Add(b2);

         lm.SortLib(3);

          Assert.NotNull(lm.library);
          Assert.IsType<List<Book>>(lm.library);
          Assert.True(Expectedlib.Any() == lm.library.Any());
        }

        [Fact]
        public void TestLibrarySortPriceDes()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Cost = 4.00m;
          b2.Cost = 5.00m;

          lm.library = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Expectedlib.Add(b1);
          Expectedlib.Add(b2);

          lm.library.Add(b2);
          lm.library.Add(b1);

          lm.SortLib(4);

          Assert.NotNull(lm.library);
          Assert.IsType<List<Book>>(lm.library);
          Assert.True(Expectedlib.Any() == lm.library.Any());
        }
    }

    public class LibraryModelSearches
    {

      [Fact]
      public void TestSearchAuthor()
      {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.BookAuthors = new List<BookAuthors>();
          b2.BookAuthors = new List<BookAuthors>();

          BookAuthors ba1 = new BookAuthors();
          Author a1 = new Author();

          a1.FirstName = "J. K.";
          a1.LastName = "author ln1";
          ba1.Authors = a1;

          BookAuthors ba2 = new BookAuthors();
          Author a2 = new Author();

          a2.FirstName = "author fn2";
          a2.LastName = "author ln2";
          ba2.Authors = a2;

          b1.Title = "A";
          b2.Title = "B";

          b1.BookAuthors.Add(ba1);
          b2.BookAuthors.Add(ba2);

          lm.library = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Expectedlib.Add(b1);

          lm.SearchAuthor("J. K.");

          Assert.NotNull(lm.library);
          Assert.IsType<List<Book>>(lm.library);
          Assert.True(Expectedlib.Any() == lm.library.Any());
      }

      [Fact]      
      public void TestGenre()
      {
        LibraryModel lm = new LibraryModel();
        Book b1 = new Book();
        Book b2 = new Book();

        b1.BookGenres = new List<BookGenres>();
        b2.BookGenres = new List<BookGenres>();

        BookGenres bg1 = new BookGenres();
        Genre g1 = new Genre();

        g1.GenreName = "testGenre";
        bg1.Genres = g1;

        BookGenres bg2 = new BookGenres();
        Genre g2 = new Genre();

        g2.GenreName = "testGenre1";
        bg2.Genres = g2;

        b1.BookGenres.Add(bg1);
        b2.BookGenres.Add(bg2);

        lm.library = new List<Book>();
        List<Book> Expectedlib = new List<Book>(); 

        lm.library.Add(b1);
        lm.library.Add(b2);

        Expectedlib.Add(b1);

        lm.SearchGenre("testGenre");

        Assert.NotNull(lm.library);
        Assert.IsType<List<Book>>(lm.library);
        //Assert.True(Expectedlib.Any() == lm.library.Any());
      }
    }
}