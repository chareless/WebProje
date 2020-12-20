﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSiteProje.Models;

namespace WebSiteProje.Migrations
{
    [DbContext(typeof(VeriContext))]
    [Migration("20201220154308_yorumduzeltme")]
    partial class yorumduzeltme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebSiteProje.Models.Blog", b =>
                {
                    b.Property<int>("blogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("altBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("boyut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eklemeTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("icerikId")
                        .HasColumnType("int");

                    b.Property<string>("icerikLinki")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("icerikYonlendirmeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("videoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("blogId");

                    b.HasIndex("icerikId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("WebSiteProje.Models.Foto", b =>
                {
                    b.Property<int>("fotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fotoAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoWidth")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fotoId");

                    b.ToTable("Foto");
                });

            modelBuilder.Entity("WebSiteProje.Models.Icerik", b =>
                {
                    b.Property<int>("icerikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("altBaslikIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("altBaslikMadde")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("anaBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("anaBaslikIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("anaBaslikMadde")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duzenlemeTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("konuBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("icerikId");

                    b.ToTable("Icerik");
                });

            modelBuilder.Entity("WebSiteProje.Models.Kullanici", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("diller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dogumTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("egitimBolum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("egitimDurumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hakkimda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meslek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("WebSiteProje.Models.Okul", b =>
                {
                    b.Property<int>("okulId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("okulAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("okulInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("okulTarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("okulTur")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("okulId");

                    b.ToTable("Okul");
                });

            modelBuilder.Entity("WebSiteProje.Models.Site", b =>
                {
                    b.Property<int>("MyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adresUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("backFotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dogumTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dogumYeri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("egitimBolumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("egitimDurumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hakkımda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meslek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profileFotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sliderFotoAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sliderFotoBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sliderFotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MyId");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("WebSiteProje.Models.SliderFoto", b =>
                {
                    b.Property<int>("sliderFotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fotoAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sliderFotoId");

                    b.ToTable("SliderFoto");
                });

            modelBuilder.Entity("WebSiteProje.Models.Sosyal", b =>
                {
                    b.Property<int>("sosyalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("sosyalFooter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sosyalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sosyalTur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sosyalUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sosyalId");

                    b.ToTable("Sosyal");
                });

            modelBuilder.Entity("WebSiteProje.Models.Yorum", b =>
                {
                    b.Property<int>("yorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("blogId")
                        .HasColumnType("int");

                    b.Property<string>("icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("kullaniciid")
                        .HasColumnType("int");

                    b.HasKey("yorumId");

                    b.HasIndex("blogId");

                    b.HasIndex("kullaniciid");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("WebSiteProje.Models.Blog", b =>
                {
                    b.HasOne("WebSiteProje.Models.Icerik", "icerik")
                        .WithMany("blog")
                        .HasForeignKey("icerikId");

                    b.Navigation("icerik");
                });

            modelBuilder.Entity("WebSiteProje.Models.Yorum", b =>
                {
                    b.HasOne("WebSiteProje.Models.Blog", "blog")
                        .WithMany()
                        .HasForeignKey("blogId");

                    b.HasOne("WebSiteProje.Models.Kullanici", "kullanici")
                        .WithMany()
                        .HasForeignKey("kullaniciid");

                    b.Navigation("blog");

                    b.Navigation("kullanici");
                });

            modelBuilder.Entity("WebSiteProje.Models.Icerik", b =>
                {
                    b.Navigation("blog");
                });
#pragma warning restore 612, 618
        }
    }
}
