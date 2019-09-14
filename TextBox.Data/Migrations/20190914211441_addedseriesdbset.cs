using Microsoft.EntityFrameworkCore.Migrations;

namespace TextBox.Data.Migrations
{
    public partial class addedseriesdbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Books_BookId",
                table: "Series");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Series",
                table: "Series");

            migrationBuilder.RenameTable(
                name: "Series",
                newName: "Seriess");

            migrationBuilder.RenameIndex(
                name: "IX_Series_BookSeries",
                table: "Seriess",
                newName: "IX_Seriess_BookSeries");

            migrationBuilder.RenameIndex(
                name: "IX_Series_BookId",
                table: "Seriess",
                newName: "IX_Seriess_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seriess",
                table: "Seriess",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seriess_Books_BookId",
                table: "Seriess",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seriess_Books_BookId",
                table: "Seriess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seriess",
                table: "Seriess");

            migrationBuilder.RenameTable(
                name: "Seriess",
                newName: "Series");

            migrationBuilder.RenameIndex(
                name: "IX_Seriess_BookSeries",
                table: "Series",
                newName: "IX_Series_BookSeries");

            migrationBuilder.RenameIndex(
                name: "IX_Seriess_BookId",
                table: "Series",
                newName: "IX_Series_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Series",
                table: "Series",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Books_BookId",
                table: "Series",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
