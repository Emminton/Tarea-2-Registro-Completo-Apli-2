﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registro_Completo.DAL;

namespace Registro_Completo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200522143237_Persona")]
    partial class Persona
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Registro_Completo.Models.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");

                    b.HasData(
                        new
                        {
                            PersonaId = 1,
                            Cedula = "0000024563",
                            Direccion = "Rio de janeiro #1286",
                            FechaNacimiento = new DateTime(2020, 5, 22, 10, 32, 36, 746, DateTimeKind.Local).AddTicks(6989),
                            Nombre = "Roberto Carlos",
                            Telefono = "8293567829"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}