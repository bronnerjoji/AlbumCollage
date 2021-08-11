using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollage.Server.Migrations
{
    public partial class WikiURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WikiURL",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WikiURL",
                table: "Albums");
        }
    }
}
