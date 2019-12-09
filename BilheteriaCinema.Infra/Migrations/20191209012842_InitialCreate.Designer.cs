﻿// <auto-generated />
using System;
using BilheteriaCinema.Infra.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BilheteriaCinema.Infra.EF.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191209012842_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BilheteriaCinema.Infra.EF.Model.FilmeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo");

                    b.Property<TimeSpan>("Duracao");

                    b.Property<int>("FaixaEtaria");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Filme","dbo");
                });

            modelBuilder.Entity("BilheteriaCinema.Infra.EF.Model.IngressoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<int>("Codigo");

                    b.Property<int>("CodigoSessao");

                    b.Property<DateTime>("DataCompra");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<int?>("SessaoId");

                    b.Property<decimal>("ValorPago");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("SessaoId");

                    b.ToTable("Ingresso","dbo");
                });

            modelBuilder.Entity("BilheteriaCinema.Infra.EF.Model.SalaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<bool>("Disponivel");

                    b.Property<int>("Lugares");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Sala","dbo");
                });

            modelBuilder.Entity("BilheteriaCinema.Infra.EF.Model.SessaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo");

                    b.Property<int>("CodigoFilme");

                    b.Property<int>("CodigoSala");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<int?>("FilmeId");

                    b.Property<DateTime>("Horario");

                    b.Property<int?>("SalaId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("FilmeId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("SalaId");

                    b.ToTable("Sessao","dbo");
                });

            modelBuilder.Entity("BilheteriaCinema.Infra.EF.Model.IngressoModel", b =>
                {
                    b.HasOne("BilheteriaCinema.Infra.EF.Model.SessaoModel", "Sessao")
                        .WithMany("Ingressos")
                        .HasForeignKey("SessaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BilheteriaCinema.Infra.EF.Model.SessaoModel", b =>
                {
                    b.HasOne("BilheteriaCinema.Infra.EF.Model.FilmeModel", "Filme")
                        .WithMany("Sessoes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BilheteriaCinema.Infra.EF.Model.SalaModel", "Sala")
                        .WithMany("Sessoes")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
