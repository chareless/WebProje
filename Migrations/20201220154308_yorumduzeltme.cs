using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteProje.Migrations
{
    public partial class yorumduzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "icerik",
                table: "Yorum",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "icerik",
                table: "Yorum");
        }
    }
}
