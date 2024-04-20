﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TipsOnPoints.Repositories;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240419005958_UpdatedCardModel2")]
    partial class UpdatedCardModel2
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

                    b.Property<int?>("ThemeId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Ca_ThemeId");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}