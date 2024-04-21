﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TipsOnPoints.Repositories;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("TipsOnPoints.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Ca_Id");

                    b.Property<string>("Answer")
                        .HasColumnType("TEXT")
                        .HasColumnName("Ca_Answer");

                    b.Property<int?>("ThemeId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Ca_ThemeId");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("TipsOnPoints.Models.CardTips", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Ct_Id");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Ct_CardId");

                    b.Property<string>("Tip")
                        .HasColumnType("TEXT")
                        .HasColumnName("Ct_Tip");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardTips");
                });

            modelBuilder.Entity("TipsOnPoints.Models.CardTips", b =>
                {
                    b.HasOne("TipsOnPoints.Models.Card", "Card")
                        .WithMany("CardTips")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("TipsOnPoints.Models.Card", b =>
                {
                    b.Navigation("CardTips");
                });
#pragma warning restore 612, 618
        }
    }
}
