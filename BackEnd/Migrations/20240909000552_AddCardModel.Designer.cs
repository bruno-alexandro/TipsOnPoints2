﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TipsOnPoints2.Models;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240909000552_AddCardModel")]
    partial class AddCardModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TipsOnPoints2.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Ca_Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .HasColumnType("text")
                        .HasColumnName("Ca_Answer");

                    b.Property<int?>("ThemeId")
                        .HasColumnType("integer")
                        .HasColumnName("Ca_ThemeId");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("TipsOnPoints2.Models.CardTips", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Ct_Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("integer")
                        .HasColumnName("Ct_CardId");

                    b.Property<string>("Tip")
                        .HasColumnType("text")
                        .HasColumnName("Ct_Tip");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardTips");
                });

            modelBuilder.Entity("TipsOnPoints2.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Th_Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("PluralTheme")
                        .HasColumnType("text")
                        .HasColumnName("Th_PluralTheme");

                    b.Property<int>("QtyTips")
                        .HasColumnType("integer")
                        .HasColumnName("Th_QtyTips");

                    b.Property<string>("SingleTheme")
                        .HasColumnType("text")
                        .HasColumnName("Th_SingleTheme");

                    b.HasKey("Id");

                    b.ToTable("Theme");
                });

            modelBuilder.Entity("TipsOnPoints2.Models.ThemeComplements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Tc_Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Complements")
                        .HasColumnType("text")
                        .HasColumnName("Tc_Complements");

                    b.Property<int>("ThemeId")
                        .HasColumnType("integer")
                        .HasColumnName("Tc_ThemeId");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("ThemeComplement");
                });

            modelBuilder.Entity("TipsOnPoints2.Models.CardTips", b =>
                {
                    b.HasOne("TipsOnPoints2.Models.Card", "Card")
                        .WithMany("CardTips")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("TipsOnPoints2.Models.ThemeComplements", b =>
                {
                    b.HasOne("TipsOnPoints2.Models.Theme", "Theme")
                        .WithMany("ThemeComplements")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("TipsOnPoints2.Models.Card", b =>
                {
                    b.Navigation("CardTips");
                });

            modelBuilder.Entity("TipsOnPoints2.Models.Theme", b =>
                {
                    b.Navigation("ThemeComplements");
                });
#pragma warning restore 612, 618
        }
    }
}
