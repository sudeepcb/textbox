using Microsoft.EntityFrameworkCore;
using TextBox.Domain.Models;

namespace TextBox.Data
{
    public class TextBoxDBContext : DbContext
    {
      //public DbSet<Book> Books { get; set; }

      public DbSet<Author> Authors { get; set; }

      public DbSet<Genre> Genres { get; set; }

      //public DbSet<Review> Reviews { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
        builder.UseSqlServer("Server=tcp:keilpizza.database.windows.net,1433;Initial Catalog=TextBoxDB;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
      }
      
      protected override void OnModelCreating(ModelBuilder builder)
      {
        //builder.Entity<Book>().HasKey(b=>b.Id);

        builder.Entity<Author>().HasKey(a=>a.Id);

        builder.Entity<Genre>().HasKey(g=>g.Id);
        builder.Entity<Genre>().HasIndex(g=>g.BookGenre).IsUnique();

        /* builder.Entity<Review>().HasKey(r=>r.Id);
        builder.Entity<Review>().HasIndex(r=>r.ReviewWriter).IsUnique();*/
      }
    }
}