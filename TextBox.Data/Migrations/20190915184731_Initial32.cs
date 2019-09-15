using Microsoft.EntityFrameworkCore.Migrations;

namespace TextBox.Data.Migrations
{
    public partial class Initial32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Seriess_SeriesId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Users_UserId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Book_BookId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenres_Book_BookId",
                table: "BookGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenres_Genres_GenreId",
                table: "BookGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_Book_BookId",
                table: "BookReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCart_Book_BookId",
                table: "BooksInCart");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksOnOrder_Book_BookId",
                table: "BooksOnOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookGenres",
                table: "BookGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "BookGenres",
                newName: "BooksGenres");

            migrationBuilder.RenameTable(
                name: "BookAuthors",
                newName: "BooksAuthors");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_BookGenres_GenreId",
                table: "BooksGenres",
                newName: "IX_BooksGenres_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BooksAuthors",
                newName: "IX_BooksAuthors_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_UserId",
                table: "Books",
                newName: "IX_Books_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_SeriesId",
                table: "Books",
                newName: "IX_Books_SeriesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksGenres",
                table: "BooksGenres",
                columns: new[] { "BookId", "GenreId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksAuthors",
                table: "BooksAuthors",
                columns: new[] { "BookId", "AuthorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Seriess_SeriesId",
                table: "Books",
                column: "SeriesId",
                principalTable: "Seriess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_UserId",
                table: "Books",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksAuthors_Authors_AuthorId",
                table: "BooksAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksAuthors_Books_BookId",
                table: "BooksAuthors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksGenres_Books_BookId",
                table: "BooksGenres",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksGenres_Genres_GenreId",
                table: "BooksGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCart_Books_BookId",
                table: "BooksInCart",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksOnOrder_Books_BookId",
                table: "BooksOnOrder",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Seriess_SeriesId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_UserId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksAuthors_Authors_AuthorId",
                table: "BooksAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksAuthors_Books_BookId",
                table: "BooksAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksGenres_Books_BookId",
                table: "BooksGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksGenres_Genres_GenreId",
                table: "BooksGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCart_Books_BookId",
                table: "BooksInCart");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksOnOrder_Books_BookId",
                table: "BooksOnOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksGenres",
                table: "BooksGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksAuthors",
                table: "BooksAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "BooksGenres",
                newName: "BookGenres");

            migrationBuilder.RenameTable(
                name: "BooksAuthors",
                newName: "BookAuthors");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenres_GenreId",
                table: "BookGenres",
                newName: "IX_BookGenres_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksAuthors_AuthorId",
                table: "BookAuthors",
                newName: "IX_BookAuthors_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_UserId",
                table: "Book",
                newName: "IX_Book_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_SeriesId",
                table: "Book",
                newName: "IX_Book_SeriesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookGenres",
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                columns: new[] { "BookId", "AuthorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Seriess_SeriesId",
                table: "Book",
                column: "SeriesId",
                principalTable: "Seriess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Users_UserId",
                table: "Book",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Book_BookId",
                table: "BookAuthors",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_Book_BookId",
                table: "BookGenres",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_Genres_GenreId",
                table: "BookGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_Book_BookId",
                table: "BookReviews",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCart_Book_BookId",
                table: "BooksInCart",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksOnOrder_Book_BookId",
                table: "BooksOnOrder",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
