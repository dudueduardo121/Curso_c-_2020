﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMvc.Models;

namespace SalesWebMvc.Migrations
{
    [DbContext(typeof(SalesWebMvcContext))]
    [Migration("20200530171406_DepartamentoForeignKey")]
    partial class DepartamentoForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMvc.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("SalesWebMvc.Models.RegistroVendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<double>("Montante");

                    b.Property<int>("status");

                    b.Property<int?>("vendedorId");

                    b.HasKey("Id");

                    b.HasIndex("vendedorId");

                    b.ToTable("RegistroVendas");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<double>("SalarioBase");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("SalesWebMvc.Models.RegistroVendas", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Vendedor", "vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("vendedorId");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Vendedor", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Departamento", "Departamento")
                        .WithMany("Vendedores")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}