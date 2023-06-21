﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdutoApi.Data;

#nullable disable

namespace ProdutoApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230621011203_MigracaoValidade02")]
    partial class MigracaoValidade02
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProdutoApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Produto01",
                            Validade = new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Valor = 20
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Produto02",
                            Validade = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Valor = 30
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Produto03",
                            Validade = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Valor = 5
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Produto04",
                            Validade = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Valor = 50
                        });
                });
#pragma warning restore 612, 618
        }
    }
}