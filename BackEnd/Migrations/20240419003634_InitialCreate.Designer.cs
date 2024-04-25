﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TipsOnPoints2.Models;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240419003634_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("SingularTheme")
                        .HasColumnType("TEXT")
                        .HasColumnName("Ca_SingularTheme");

                    b.Property<string>("Test")
                        .HasColumnType("TEXT")
                        .HasColumnName("Ca_Test");

                    b.Property<string>("Theme")
                        .HasColumnType("TEXT")
                        .HasColumnName("Ca_Theme");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
