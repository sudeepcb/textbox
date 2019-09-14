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

                    b.Property<int?>("BookId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("FirstName", "LastName")
                        .IsUnique()
                        .HasFilter("[FirstName] IS NOT NULL AND [LastName] IS NOT NULL");

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

                    b.Property<int?>("CartId");

                    b.Property<decimal>("Cost");

                    b.Property<string>("ISBN");

                    b.Property<int?>("OrderId");

                    b.Property<int>("Pages");

                    b.Property<string>("Publisher");

                    b.Property<int?>("RecommendationId");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.HasIndex("RecommendationId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("TotalCost");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookGenre");

                    b.Property<int?>("BookId");

                    b.HasKey("Id");

                    b.HasIndex("BookGenre")
                        .IsUnique()
                        .HasFilter("[BookGenre] IS NOT NULL");

                    b.HasIndex("BookId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("OrderPaid");

                    b.Property<decimal>("TotalCost");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Recommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Recommendations");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId");

                    b.Property<string>("Content");

                    b.Property<double>("RatingScore");

                    b.Property<string>("ReviewTitle");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<string>("BookSeries");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.HasIndex("BookSeries")
                        .IsUnique()
                        .HasFilter("[BookSeries] IS NOT NULL");

                    b.ToTable("Series");
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

            modelBuilder.Entity("TextBox.Domain.Models.Author", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Book", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Cart")
                        .WithMany("BooksInCart")
                        .HasForeignKey("CartId");

                    b.HasOne("TextBox.Domain.Models.Order")
                        .WithMany("BooksOnOrder")
                        .HasForeignKey("OrderId");

                    b.HasOne("TextBox.Domain.Models.Recommendation")
                        .WithMany("RecommendedBooks")
                        .HasForeignKey("RecommendationId");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Cart", b =>
                {
                    b.HasOne("TextBox.Domain.Models.User", "User")
                        .WithOne("CurrentCart")
                        .HasForeignKey("TextBox.Domain.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TextBox.Domain.Models.Genre", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Book")
                        .WithMany("BookGenres")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Order", b =>
                {
                    b.HasOne("TextBox.Domain.Models.User")
                        .WithMany("OrderHistory")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Review", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Book")
                        .WithMany("userReviews")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("TextBox.Domain.Models.Series", b =>
                {
                    b.HasOne("TextBox.Domain.Models.Book", "Book")
                        .WithOne("BookSeries")
                        .HasForeignKey("TextBox.Domain.Models.Series", "BookId")
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
