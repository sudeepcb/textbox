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
        public void TestLibrarySort()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Title = "Title";
          b2.Title = "Title2";

          List<Book> Testlib = new List<Book>();

          Testlib.Add(b1);
          Testlib.Add(b2);

          var testresult = lm.Sort(Testlib,-1);

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
        }

        [Fact]
        public void TestLibrarySortAsc()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Title = "A";
          b2.Title = "B";

          List<Book> Testlib = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Expectedlib.Add(b1);
          Expectedlib.Add(b2);

          Testlib.Add(b2);
          Testlib.Add(b1);

          var testresult = lm.SortAsc(Testlib);

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
          Assert.True(Expectedlib.Any() == testresult.Any());
        }

        [Fact]
        public void TestLibrarySortDes()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Title = "A";
          b2.Title = "B";

          List<Book> Testlib = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Expectedlib.Add(b2);
          Expectedlib.Add(b1);

          Testlib.Add(b1);
          Testlib.Add(b2);

          var testresult = lm.SortAsc(Testlib);

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
          Assert.True(Expectedlib.Any() == testresult.Any());
        }

        [Fact]
        public void TestLibrarySortPrice()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Cost = 4.00m;
          b2.Cost = 5.00m;

          List<Book> Testlib = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Expectedlib.Add(b2);
          Expectedlib.Add(b1);

          Testlib.Add(b1);
          Testlib.Add(b2);

          var testresult = lm.SortPrice(Testlib);

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
          Assert.True(Expectedlib.Any() == testresult.Any());
        }

        [Fact]
        public void TestLibrarySortPriceDes()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Cost = 4.00m;
          b2.Cost = 5.00m;

          List<Book> Testlib = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Expectedlib.Add(b1);
          Expectedlib.Add(b2);

          Testlib.Add(b2);
          Testlib.Add(b1);

          var testresult = lm.SortPriceDes(Testlib);

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
          Assert.True(Expectedlib.Any() == testresult.Any());
        }

        [Fact]
        public void TestLibrarySortNew()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.ReleaseDate = new System.DateTime(1111,1,11);
          b2.ReleaseDate = new System.DateTime(1800,2,22);

          List<Book> Testlib = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Expectedlib.Add(b2);
          Expectedlib.Add(b1);

          Testlib.Add(b1);
          Testlib.Add(b2);

          var testresult = lm.SortNew(Testlib);

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
          Assert.True(Expectedlib.Any() == testresult.Any());
        }

        [Fact]
        public void TestLibrarySortNewDes()
        {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.ReleaseDate = new System.DateTime(1111,1,11);
          b2.ReleaseDate = new System.DateTime(1800,2,22);

          List<Book> Testlib = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Expectedlib.Add(b1);
          Expectedlib.Add(b2);

          Testlib.Add(b2);
          Testlib.Add(b1);

          var testresult = lm.SortNew(Testlib);

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
          Assert.True(Expectedlib.Any() == testresult.Any());
        }
    }

    public class LibraryModelSearches
    {
      [Fact]
      public void TestSearch()
      {
          LibraryModel lm = new LibraryModel();
          Book b1 = new Book();
          Book b2 = new Book();

          b1.Title = "Title";
          b2.Title = "Title2";

          List<Book> Testlib = new List<Book>();

          Testlib.Add(b1);
          Testlib.Add(b2);

          var testresult = lm.Search(Testlib,-1);

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
      }

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

          a1.FirstName = "author";
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

          List<Book> Testlib = new List<Book>();
          List<Book> Expectedlib = new List<Book>();

          Testlib.Add(b1);
          Testlib.Add(b2);

          Expectedlib.Add(b1);

          var testresult = lm.SearchAuthor(Testlib,"author");

          Assert.NotNull(testresult);
          Assert.IsType<List<Book>>(testresult);
          Assert.True(Expectedlib.Any() == testresult.Any());
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

        List<Book> Testlib = new List<Book>();
        List<Book> Expectedlib = new List<Book>(); 

        Testlib.Add(b1);
        Testlib.Add(b2);

        Expectedlib.Add(b1);

        var testresult = lm.SearchGenre(Testlib,"testGenre");

        Assert.NotNull(testresult);
        Assert.IsType<List<Book>>(testresult);
        Assert.True(Expectedlib.Any() == testresult.Any());
      }
    }
}