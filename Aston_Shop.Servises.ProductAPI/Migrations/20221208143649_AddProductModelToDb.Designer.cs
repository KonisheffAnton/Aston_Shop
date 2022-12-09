﻿// <auto-generated />
using Aston_Shop.Servises.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AstonShop.Servises.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221208143649_AddProductModelToDb")]
    partial class AddProductModelToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Aston_Shop.Servises.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryName_Product")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description_Product")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl_Product")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name_Product")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price_Product")
                        .HasColumnType("double precision");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
