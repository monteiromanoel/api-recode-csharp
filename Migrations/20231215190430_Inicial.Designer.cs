﻿// <auto-generated />
using System;
using ApiAgenciaRecode.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiAgenciaRecode.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20231215190430_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiAgenciaRecode.Model.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cep")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateOnly>("dataNasc")
                        .HasColumnType("date");

                    b.Property<string>("documento")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("logradouro")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("telefone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("uf")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ApiAgenciaRecode.Model.Destino", b =>
                {
                    b.Property<int>("DestinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("adicional")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<DateOnly>("data_ida")
                        .HasColumnType("date");

                    b.Property<DateOnly>("data_volta")
                        .HasColumnType("date");

                    b.Property<string>("descricao_curta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("descricao_longa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("destino")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("imagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("imagem2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("imagem3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("imagem4")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("localidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<decimal>("preco")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("preco_antigo")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("tipo_pacote")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DestinoId");

                    b.ToTable("Destino");
                });

            modelBuilder.Entity("ApiAgenciaRecode.Model.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataReserva")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<int>("NumPassageiros")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ReservaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("DestinoId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("ApiAgenciaRecode.Model.Reserva", b =>
                {
                    b.HasOne("ApiAgenciaRecode.Model.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAgenciaRecode.Model.Destino", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Destino");
                });
#pragma warning restore 612, 618
        }
    }
}
