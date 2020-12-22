using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteProje.Migrations
{
    public partial class blogicerikduzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Icerik_icerikId",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_icerikId",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "altBaslikIcerik",
                table: "Icerik");

            migrationBuilder.DropColumn(
                name: "altBaslikMadde",
                table: "Icerik");

            migrationBuilder.DropColumn(
                name: "anaBaslik",
                table: "Icerik");

            migrationBuilder.DropColumn(
                name: "icerikId",
                table: "Blog");

            migrationBuilder.RenameColumn(
                name: "konuBaslik",
                table: "Icerik",
                newName: "metinUst");

            migrationBuilder.RenameColumn(
                name: "fotoUrl",
                table: "Icerik",
                newName: "metinAlt");

            migrationBuilder.RenameColumn(
                name: "duzenlemeTarihi",
                table: "Icerik",
                newName: "madde");

            migrationBuilder.RenameColumn(
                name: "anaBaslikMadde",
                table: "Icerik",
                newName: "idTag");

            migrationBuilder.RenameColumn(
                name: "anaBaslikIcerik",
                table: "Icerik",
                newName: "baslik");

            migrationBuilder.RenameColumn(
                name: "icerikYonlendirmeUrl",
                table: "Blog",
                newName: "uyari");

            migrationBuilder.AddColumn<int>(
                name: "blogId",
                table: "Icerik",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "blogTur",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "degistirmeTarihi",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "idName",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "iframeUrl",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "linkAciklama",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Icerik_blogId",
                table: "Icerik",
                column: "blogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Icerik_Blog_blogId",
                table: "Icerik",
                column: "blogId",
                principalTable: "Blog",
                principalColumn: "blogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icerik_Blog_blogId",
                table: "Icerik");

            migrationBuilder.DropIndex(
                name: "IX_Icerik_blogId",
                table: "Icerik");

            migrationBuilder.DropColumn(
                name: "blogId",
                table: "Icerik");

            migrationBuilder.DropColumn(
                name: "blogTur",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "degistirmeTarihi",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "idName",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "iframeUrl",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "linkAciklama",
                table: "Blog");

            migrationBuilder.RenameColumn(
                name: "metinUst",
                table: "Icerik",
                newName: "konuBaslik");

            migrationBuilder.RenameColumn(
                name: "metinAlt",
                table: "Icerik",
                newName: "fotoUrl");

            migrationBuilder.RenameColumn(
                name: "madde",
                table: "Icerik",
                newName: "duzenlemeTarihi");

            migrationBuilder.RenameColumn(
                name: "idTag",
                table: "Icerik",
                newName: "anaBaslikMadde");

            migrationBuilder.RenameColumn(
                name: "baslik",
                table: "Icerik",
                newName: "anaBaslikIcerik");

            migrationBuilder.RenameColumn(
                name: "uyari",
                table: "Blog",
                newName: "icerikYonlendirmeUrl");

            migrationBuilder.AddColumn<string>(
                name: "altBaslikIcerik",
                table: "Icerik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "altBaslikMadde",
                table: "Icerik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "anaBaslik",
                table: "Icerik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "icerikId",
                table: "Blog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blog_icerikId",
                table: "Blog",
                column: "icerikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Icerik_icerikId",
                table: "Blog",
                column: "icerikId",
                principalTable: "Icerik",
                principalColumn: "icerikId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
