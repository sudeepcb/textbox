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

    public class TestLibraryModel
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
}