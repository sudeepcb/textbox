using Microsoft.EntityFrameworkCore.Migrations;

namespace TextBox.Data.Migrations
{
    public partial class addedseriesrelationshiptobook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Series_BookSeriesId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookSeriesId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookSeriesId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Series",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Series_BookId",
                table: "Series",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Books_BookId",
                table: "Series",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Books_BookId",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "IX_Series_BookId",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Series");

            migrationBuilder.AddColumn<int>(
                name: "BookSeriesId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookSeriesId",
                table: "Books",
                column: "BookSeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Series_BookSeriesId",
                table: "Books",
                column: "BookSeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
