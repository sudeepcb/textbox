using Microsoft.EntityFrameworkCore;
using TextBox.Domain.Models;

namespace TextBox.Data
{
    public class TextBoxDBContext : DbContext
    {
      public DbSet<Author> Authors { get; set; }
      public DbSet<Book> Books { get; set; }
      public DbSet<BookAuthors> BooksAuthors { get; set; }
      public DbSet<BookGenres> BooksGenres { get; set; }
      public DbSet<BookSeries> BookInSeries { get; set; }      
      public DbSet<BookReviews> BookReviews { get; set; }
      public DbSet<BooksInCart> BooksInCarts {get; set;}
      public DbSet<BooksOnOrder> BooksOnOrder {get; set;}
      public DbSet<Cart> Carts { get; set; }
      public DbSet<Genre> Genres { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<OrderHistory> OrderHistory { get; set; }
      public DbSet<Review> Reviews { get; set; }
      public DbSet<Series> Seriess { get; set; }
      public DbSet<User> Users { get; set; }
      
      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
        builder.UseSqlServer("Server=tcp:keilpizza.database.windows.net,1433;Initial Catalog=TextBoxDB;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
      }
      
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Author>().HasKey(a=>a.Id);

        builder.Entity<Book>().HasKey(b=>b.Id);
        builder.Entity<Book>().HasMany(r=>r.userReviews).WithOne();
        
        builder.Entity<BookAuthors>().HasKey(x=> new{x.BookId, x.AuthorId});
        builder.Entity<BookAuthors>().HasOne(x=>x.Authors).WithMany(a=>a.BookAuthors).HasForeignKey(x => x.AuthorId);
        builder.Entity<BookAuthors>().HasOne(x=>x.Books).WithMany(b=>b.BookAuthors).HasForeignKey(x => x.BookId);

        builder.Entity<BookGenres>().HasKey(x=> new{x.BookId, x.GenreId});
        builder.Entity<BookGenres>().HasOne(x=>x.Genres).WithMany(a=>a.BookGenres).HasForeignKey(x => x.GenreId);
        builder.Entity<BookGenres>().HasOne(x=>x.Books).WithMany(b=>b.BookGenres).HasForeignKey(x => x.BookId);

        builder.Entity<BookSeries>().HasKey(x=> new{x.BookId, x.SeriesId});
        builder.Entity<BookSeries>().HasOne(x=>x.Series).WithMany(a=>a.BooksInSeries).HasForeignKey(x => x.SeriesId);
        builder.Entity<BookSeries>().HasOne(x=>x.Books).WithMany(b=>b.BooksInSeries).HasForeignKey(x => x.BookId);

        builder.Entity<BookReviews>().HasKey(x=> new{x.BookId, x.ReviewId});
        builder.Entity<BookReviews>().HasOne(x=>x.Review).WithMany(a=>a.userReviews).HasForeignKey(x => x.ReviewId);
        builder.Entity<BookReviews>().HasOne(x=>x.Books).WithMany(b=>b.userReviews).HasForeignKey(x => x.BookId);

        builder.Entity<BooksInCart>().HasKey(x=> new{x.BookId, x.CartId});
        // builder.Entity<BooksInCart>().HasOne(x=>x.Cart).WithMany(o=>o.BooksInCart).HasForeignKey(x => x.CartId);
        // builder.Entity<BooksInCart>().HasOne(x=>x.Books).WithMany(o=>o.BooksInCart).HasForeignKey(x => x.BookId);        

        builder.Entity<BooksOnOrder>().HasKey(x=> new{x.BookId, x.OrderId});
        builder.Entity<BooksOnOrder>().HasOne(x=>x.Order).WithMany(o=>o.BooksOnOrder).HasForeignKey(x => x.BookId);
        builder.Entity<BooksOnOrder>().HasOne(x=>x.Books).WithMany(o=>o.BooksOnOrder).HasForeignKey(x => x.OrderId);

        builder.Entity<Cart>().HasKey(x=> new{x.Id, x.UserId});
        
        builder.Entity<Genre>().HasKey(g=>g.Id);
        builder.Entity<Genre>().HasIndex(s=>s.GenreName).IsUnique();

        builder.Entity<Order>().HasKey(o=>o.Id);

        builder.Entity<OrderHistory>().HasKey(x=> new{x.OrderId, x.UserId});        

        builder.Entity<Review>().HasKey(r=>r.Id);
        builder.Entity<Review>().HasOne(u=>u.ReviewWriter).WithOne(u=>u.Review).HasForeignKey<User>(r=>r.ReviewId);

        builder.Entity<Series>().HasKey(s=>s.Id);
        builder.Entity<Series>().HasIndex(s=>s.SeriesName).IsUnique();

        builder.Entity<User>().HasKey(u=>u.Id);
        builder.Entity<User>().HasIndex(u=>u.Username).IsUnique();
        builder.Entity<User>().HasOne(u=>u.OrderHistory).WithOne(h=>h.User).HasForeignKey<OrderHistory>(u=>u.UserId);
        builder.Entity<User>().HasOne(u=>u.CurrentCart).WithOne(u=>u.User).HasForeignKey<Cart>(u=>u.UserId);
        builder.Entity<User>().HasOne(u=>u.Order).WithOne(u=>u.User).HasForeignKey<Order>(u=>u.UserId);
        }
    }
}