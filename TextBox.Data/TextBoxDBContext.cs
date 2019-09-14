using Microsoft.EntityFrameworkCore;
using TextBox.Domain.Models;

namespace TextBox.Data
{
    public class TextBoxDBContext : DbContext
    {
      public DbSet<Book> Books { get; set; }
      public DbSet<Author> Authors { get; set; }
      public DbSet<Genre> Genres { get; set; }
      public DbSet<Review> Reviews { get; set; }
      public DbSet<Recommendation> Recommendations { get; set; }
      public DbSet<User> Users { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<Cart> Carts { get; set; }
      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
        builder.UseSqlServer("Server=tcp:keilpizza.database.windows.net,1433;Initial Catalog=TextBoxDB;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
      }
      
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Book>().HasKey(b=>b.Id);
        builder.Entity<Book>().HasOne(s=>s.BookSeries).WithOne(b=>b.Book).HasForeignKey<Series>(b=>b.BookId);
        builder.Entity<Book>().HasMany(a=>a.BookAuthors).WithOne();
        builder.Entity<Book>().HasMany(g=>g.BookGenres).WithOne();
        builder.Entity<Book>().HasMany(r=>r.userReviews).WithOne();

        builder.Entity<User>().HasKey(u=>u.Id);
        builder.Entity<User>().HasIndex(u=>u.Username).IsUnique();
        builder.Entity<User>().HasMany(o=>o.OrderHistory).WithOne();
        builder.Entity<User>().HasOne(c=>c.CurrentCart).WithOne(u=>u.User).HasForeignKey<Cart>(u=>u.UserId);

        builder.Entity<Order>().HasKey(o=>o.Id);
        builder.Entity<Order>().HasMany(b=>b.BooksOnOrder).WithOne();

        builder.Entity<Cart>().HasKey(c=>c.Id);
        builder.Entity<Cart>().HasMany(b=>b.BooksInCart).WithOne();

        builder.Entity<Recommendation>().HasKey(r=>r.Id);
        builder.Entity<Recommendation>().HasMany(rb=>rb.RecommendedBooks).WithOne();

        builder.Entity<Review>().HasKey(r=>r.Id);
        builder.Entity<Review>().HasOne(u=>u.ReviewWriter).WithOne(u=>u.Review).HasForeignKey<User>(r=>r.ReviewId);

        builder.Entity<Author>().HasKey(a=>a.Id);
        builder.Entity<Author>().HasIndex(a => new { a.FirstName, a.LastName}).IsUnique();

        builder.Entity<Genre>().HasKey(g=>g.Id);
        builder.Entity<Genre>().HasIndex(g=>g.BookGenre).IsUnique();

        builder.Entity<Series>().HasKey(s=>s.Id);
        builder.Entity<Series>().HasIndex(s=>s.BookSeries).IsUnique();

      }
    }
}