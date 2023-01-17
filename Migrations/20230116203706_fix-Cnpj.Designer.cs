﻿// <auto-generated />
using DivTech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DivTech.Migrations
{
    [DbContext(typeof(FornecedorContext))]
    [Migration("20230116203706_fix-Cnpj")]
    partial class fixCnpj
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DivTech.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CNPJ")
                        .HasColumnType("int")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Name");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Specialty");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });
#pragma warning restore 612, 618
        }
    }
}
