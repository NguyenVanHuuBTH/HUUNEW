﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CUONGDB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("CUONGDB.Models.HUU", b =>
                {
                    b.Property<string>("HUUID")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("HUUName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("HUUSL")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("HUUSL02")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("HUUSđt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("HUUID");

                    b.ToTable("HUU");
                });

            modelBuilder.Entity("CUONGDB.Models.LOPHOC", b =>
                {
                    b.Property<int?>("MaLop")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<string>("SoLuong")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaLop");

                    b.ToTable("LOPHOC");
                });
#pragma warning restore 612, 618
        }
    }
}
