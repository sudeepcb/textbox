using Microsoft.EntityFrameworkCore.Migrations;

namespace TextBox.Data.Migrations
{
    public partial class Initial99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCart_Books_BookId",
                table: "BooksInCart");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCart_Carts_CartId1_CartUserId",
                table: "BooksInCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksInCart",
                table: "BooksInCart");

            migrationBuilder.RenameTable(
                name: "BooksInCart",
                newName: "BooksInCarts");

            migrationBuilder.RenameIndex(
                name: "IX_BooksInCart_CartId1_CartUserId",
                table: "BooksInCarts",
                newName: "IX_BooksInCarts_CartId1_CartUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksInCarts",
                table: "BooksInCarts",
                columns: new[] { "BookId", "CartId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCarts_Books_BookId",
                table: "BooksInCarts",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCarts_Carts_CartId1_CartUserId",
                table: "BooksInCarts",
                columns: new[] { "CartId1", "CartUserId" },
                principalTable: "Carts",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCarts_Books_BookId",
                table: "BooksInCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCarts_Carts_CartId1_CartUserId",
                table: "BooksInCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksInCarts",
                table: "BooksInCarts");

            migrationBuilder.RenameTable(
                name: "BooksInCarts",
                newName: "BooksInCart");

            migrationBuilder.RenameIndex(
                name: "IX_BooksInCarts_CartId1_CartUserId",
                table: "BooksInCart",
                newName: "IX_BooksInCart_CartId1_CartUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksInCart",
                table: "BooksInCart",
                columns: new[] { "BookId", "CartId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCart_Books_BookId",
                table: "BooksInCart",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCart_Carts_CartId1_CartUserId",
                table: "BooksInCart",
                columns: new[] { "CartId1", "CartUserId" },
                principalTable: "Carts",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
