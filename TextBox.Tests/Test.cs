using System.Collections.Generic;
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
    }
}