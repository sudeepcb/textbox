using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TextBox.Data.Migrations
{
    public partial class addseriestodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Series",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookSeriesId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookSeries = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookSeriesId",
                table: "Books",
                column: "BookSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_BookSeries",
                table: "Series",
                column: "BookSeries",
                unique: true,
                filter: "[BookSeries] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Series_BookSeriesId",
                table: "Books",
                column: "BookSeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Series_BookSeriesId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookSeriesId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookSeriesId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Books",
                nullable: true);
        }
    }
}
