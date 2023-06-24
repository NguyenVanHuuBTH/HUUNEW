﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CUONGDB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230624154453_Add_Colum_LOPHOC_SoLuong")]
    partial class Add_Colum_LOPHOC_SoLuong
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("CUONGDB.Models.LOPHOC", b =>
                {
                    b.Property<int?>("MaLop")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<string>("SoLuong")
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
