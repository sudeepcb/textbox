﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TextBox.Data;

namespace TextBox.Data.Migrations
{
    [DbContext(typeof(TextBoxDBContext))]
    partial class TextBoxDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TextBox.Domain.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountSold");

                    b.Property<double>("AverageRating");

                    b.Property<string>("BookCover");

                    b.Property<decimal>("Cost");

                    b.Property<string>("ISBN");

                    b.Property<int>("Pages");

                    b.Property<string>("Publisher");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Title");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("TextBox.Domain.Models.BookAuthors", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("AuthorId");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BooksAuthors");
                });

            modelBuilder.Entity("TextBox.Domain.Models.BookGenres", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("GenreId");

                    b.HasKey("BookId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BooksGenres");
                });

            modelBuilder.Entity("TextBox.Domain.Models.BookReviews", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("ReviewId");

                    b.HasKey("BookId", "ReviewId");

                    b.HasIndex("ReviewId");

                    b.ToTable("BookReviews");
                });

            modelBuilder.Entity("TextBox.Domain.Models.BookSeries", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("SeriesId");

                    b.HasKey("BookId", "SeriesId");

                    b.HasIndex("SeriesId");

                    b.ToTable("BookInSeries");
                });

            modelBuilder.Entity("TextBox.Domain.Models.BooksOnOrder", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("OrderId");

                    b.HasKey("BookId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("BooksOnOrder");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Cart", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("UserId");

                    b.Property<decimal>("TotalCost");

                    b.HasKey("Id", "UserId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName");

                    b.HasKey("Id");

                    b.HasIndex("GenreName")
                        .IsUnique()
                        .HasFilter("[GenreName] IS NOT NULL");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("OrderPaid");

                    b.Property<decimal>("TotalCost");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<double>("RatingScore");

                    b.Property<string>("ReviewTitle");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SeriesName");

                    b.HasKey("Id");

                    b.HasIndex("SeriesName")
                        .IsUnique()
                        .HasFilter("[SeriesName] IS NOT NULL");

                    b.ToTable("Seriess");
                });

            modelBuilder.Entity("TextBox.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int>("ReviewId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Book", b =>
                {
                    b.HasOne("TextBox.Domain.Models.User")
                        .WithMany("BooksInOrder")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TextBox.Domain.Models.BookAuthors", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Author", "Authors")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TextBox.Domain.Models.Book", "Books")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TextBox.Domain.Models.BookGenres", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Book", "Books")
                        .WithMany("BookGenres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TextBox.Domain.Models.Genre", "Genres")
                        .WithMany("BookGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TextBox.Domain.Models.BookReviews", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Book", "Books")
                        .WithMany("userReviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TextBox.Domain.Models.Review", "Review")
                        .WithMany("userReviews")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TextBox.Domain.Models.BookSeries", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Book", "Books")
                        .WithMany("BooksInSeries")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TextBox.Domain.Models.Series", "Series")
                        .WithMany("BooksInSeries")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TextBox.Domain.Models.BooksOnOrder", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Book", "Books")
                        .WithMany("BooksOnOrder")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TextBox.Domain.Models.Order", "Order")
                        .WithMany("BooksOnOrder")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TextBox.Domain.Models.Cart", b =>
                {
                    b.HasOne("TextBox.Domain.Models.User", "User")
                        .WithOne("CurrentCart")
                        .HasForeignKey("TextBox.Domain.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TextBox.Domain.Models.Order", b =>
                {
                    b.HasOne("TextBox.Domain.Models.User", "User")
                        .WithOne("Order")
                        .HasForeignKey("TextBox.Domain.Models.Order", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TextBox.Domain.Models.User", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Review", "Review")
                        .WithOne("ReviewWriter")
                        .HasForeignKey("TextBox.Domain.Models.User", "ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
