﻿// <auto-generated />
using System;
using MJPruebaProgreso1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MJPruebaProgreso1.Migrations
{
    [DbContext(typeof(MJPruebaProgreso1Context))]
    [Migration("20240424155707_MateoJaramilloDb")]
    partial class MateoJaramilloDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MJPruebaProgreso1.Models.MJ_Tacos", b =>
                {
                    b.Property<int>("TacoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TacoID"));

                    b.Property<string>("MJ_DescripcionDelTaco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MJ_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MJ_Guacamole")
                        .HasColumnType("bit");

                    b.Property<string>("MJ_NombreTaco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MJ_PrecioTaco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TacoID");

                    b.ToTable("MJ_Tacos");
                });
#pragma warning restore 612, 618
        }
    }
}
