﻿// <auto-generated />
using System;
using BumbaApiGraphQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BumbaApiGraphQL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("BumbaApiGraphQL.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("End")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Cemiterio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastramento")
                        .HasColumnType("TEXT");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Cemiterios");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Defunto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CemiterioId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastramento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataEnterro")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataFalecimento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeParente")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroIdentidade")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<string>("TerminalParente")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoIdentidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CemiterioId");

                    b.ToTable("Defuntos");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastramento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastramento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroIdentidade")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoIdentidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Proprietarios");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastramento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Transladacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CemiterioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CertificadoObito")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCadastramento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataEnterro")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataFalecimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .HasColumnType("TEXT");

                    b.Property<int>("Idade")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTransladacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naturalidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeMae")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomePai")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProcessoConservacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Responsavel")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CemiterioId");

                    b.ToTable("Transladacao");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastramento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Utente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastramento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroIdentidade")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoIdentidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Utentes");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Cemiterio", b =>
                {
                    b.HasOne("BumbaApiGraphQL.Models.Municipio", "Municipio")
                        .WithMany("Cemiterios")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Defunto", b =>
                {
                    b.HasOne("BumbaApiGraphQL.Models.Cemiterio", "Cemiterio")
                        .WithMany("Defuntos")
                        .HasForeignKey("CemiterioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cemiterio");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Municipio", b =>
                {
                    b.HasOne("BumbaApiGraphQL.Models.Provincia", "Provincia")
                        .WithMany("Municipios")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Transladacao", b =>
                {
                    b.HasOne("BumbaApiGraphQL.Models.Cemiterio", "Cemiterio")
                        .WithMany("Transladacaos")
                        .HasForeignKey("CemiterioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cemiterio");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Utente", b =>
                {
                    b.HasOne("BumbaApiGraphQL.Models.Municipio", "Municipio")
                        .WithMany("Utentes")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Cemiterio", b =>
                {
                    b.Navigation("Defuntos");

                    b.Navigation("Transladacaos");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Municipio", b =>
                {
                    b.Navigation("Cemiterios");

                    b.Navigation("Utentes");
                });

            modelBuilder.Entity("BumbaApiGraphQL.Models.Provincia", b =>
                {
                    b.Navigation("Municipios");
                });
#pragma warning restore 612, 618
        }
    }
}
