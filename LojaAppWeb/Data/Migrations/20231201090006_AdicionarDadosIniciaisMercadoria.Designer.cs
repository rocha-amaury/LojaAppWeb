﻿// <auto-generated />
using System;
using LojaAppWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LojaAppWeb.Data.Migrations
{
    [DbContext(typeof(LojaDbContext))]
    [Migration("20231201090006_AdicionarDadosIniciaisMercadoria")]
    partial class AdicionarDadosIniciaisMercadoria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LojaAppWeb.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("MarcaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("LojaAppWeb.Models.Mercadoria", b =>
                {
                    b.Property<int>("MercadoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MercadoriaId"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EntregaExpressa")
                        .HasColumnType("bit");

                    b.Property<string>("ImagemUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("MercadoriaId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Mercadoria");
                });

            modelBuilder.Entity("LojaAppWeb.Models.Mercadoria", b =>
                {
                    b.HasOne("LojaAppWeb.Models.Marca", null)
                        .WithMany("Mercadorias")
                        .HasForeignKey("MarcaId");
                });

            modelBuilder.Entity("LojaAppWeb.Models.Marca", b =>
                {
                    b.Navigation("Mercadorias");
                });
#pragma warning restore 612, 618
        }
    }
}
