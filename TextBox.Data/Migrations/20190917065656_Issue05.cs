using Microsoft.EntityFrameworkCore.Migrations;

namespace TextBox.Data.Migrations
{
    public partial class Issue05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksOnOrder_Orders_BookId",
                table: "BooksOnOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksOnOrder_Books_OrderId",
                table: "BooksOnOrder");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksOnOrder_Books_BookId",
                table: "BooksOnOrder",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksOnOrder_Orders_OrderId",
                table: "BooksOnOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksOnOrder_Books_BookId",
                table: "BooksOnOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksOnOrder_Orders_OrderId",
                table: "BooksOnOrder");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksOnOrder_Orders_BookId",
                table: "BooksOnOrder",
                column: "BookId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksOnOrder_Books_OrderId",
                table: "BooksOnOrder",
                column: "OrderId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
