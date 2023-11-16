﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcFei.Data;

#nullable disable

namespace MvcFei.Migrations
{
    [DbContext(typeof(MvcFeiContext))]
    [Migration("20231109040819_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcFei.Models.Alumno", b =>
                {
                    b.Property<string>("AlumnoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Carrera")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Promedio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AlumnoId");

                    b.ToTable("Alumno");
                });
#pragma warning restore 612, 618
        }
    }
}
