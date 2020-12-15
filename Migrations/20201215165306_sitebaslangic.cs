using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteProje.Migrations
{
    public partial class sitebaslangic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    fotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotoBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotoAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotoWidth = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.fotoId);
                });

            migrationBuilder.CreateTable(
                name: "Icerik",
                columns: table => new
                {
                    icerikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anaBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    anaBaslikIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    anaBaslikMadde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    konuBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altBaslikIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altBaslikMadde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duzenlemeTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icerik", x => x.icerikId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meslek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hakkimda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dogumTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    egitimDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    egitimBolum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Okul",
                columns: table => new
                {
                    okulId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    okulAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    okulTarih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    okulTur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    okulInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okul", x => x.okulId);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    MyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meslek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profileFotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    backFotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hakkımda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dogumTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dogumYeri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    egitimDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    egitimBolumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adresUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sliderFotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sliderFotoBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sliderFotoAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.MyId);
                });

            migrationBuilder.CreateTable(
                name: "SliderFoto",
                columns: table => new
                {
                    sliderFotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotoBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotoAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderFoto", x => x.sliderFotoId);
                });

            migrationBuilder.CreateTable(
                name: "Sosyal",
                columns: table => new
                {
                    sosyalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sosyalUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sosyalTur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sosyalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sosyalFooter = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sosyal", x => x.sosyalId);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    blogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    videoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    icerikLinki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eklemeTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    boyut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    icerikYonlendirmeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    icerikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.blogId);
                    table.ForeignKey(
                        name: "FK_Blog_Icerik_icerikId",
                        column: x => x.icerikId,
                        principalTable: "Icerik",
                        principalColumn: "icerikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    yorumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciid = table.Column<int>(type: "int", nullable: true),
                    blogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.yorumId);
                    table.ForeignKey(
                        name: "FK_Yorum_Blog_blogId",
                        column: x => x.blogId,
                        principalTable: "Blog",
                        principalColumn: "blogId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Yorum_Kullanici_kullaniciid",
                        column: x => x.kullaniciid,
                        principalTable: "Kullanici",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_icerikId",
                table: "Blog",
                column: "icerikId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_blogId",
                table: "Yorum",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_kullaniciid",
                table: "Yorum",
                column: "kullaniciid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropTable(
                name: "Okul");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "SliderFoto");

            migrationBuilder.DropTable(
                name: "Sosyal");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Icerik");
        }
    }
}
