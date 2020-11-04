﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using maximo_P2_A2.Data;

namespace maximo_P2_A2.Data.migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201104192917_migracionInicial")]
    partial class migracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("maximo_P2_A2.Entities.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("maximo_P2_A2.Entities.CobroDetalles", b =>
                {
                    b.Property<int>("CobroDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cobrado")
                        .HasColumnType("REAL");

                    b.Property<int>("CobroId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MontoVenta")
                        .HasColumnType("REAL");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CobroDetalleId");

                    b.HasIndex("CobroId");

                    b.ToTable("CobroDetalles");
                });

            modelBuilder.Entity("maximo_P2_A2.Entities.Cobros", b =>
                {
                    b.Property<int>("CobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("MontoCobrado")
                        .HasColumnType("REAL");

                    b.Property<string>("Observaciones")
                        .HasColumnType("TEXT");

                    b.Property<int?>("clientesClienteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CobroId");

                    b.HasIndex("clientesClienteId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("maximo_P2_A2.Entities.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("maximo_P2_A2.Entities.CobroDetalles", b =>
                {
                    b.HasOne("maximo_P2_A2.Entities.Cobros", null)
                        .WithMany("detalle")
                        .HasForeignKey("CobroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("maximo_P2_A2.Entities.Cobros", b =>
                {
                    b.HasOne("maximo_P2_A2.Entities.Clientes", "clientes")
                        .WithMany()
                        .HasForeignKey("clientesClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}
