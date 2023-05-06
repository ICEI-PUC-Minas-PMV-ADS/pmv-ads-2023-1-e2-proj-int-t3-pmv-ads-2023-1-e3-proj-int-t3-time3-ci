﻿// <auto-generated />
using System;
using CondominioInteligente.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CondominioInteligente.Migrations
{
    [DbContext(typeof(CondominioInteligenteContext))]
    [Migration("20230506153535_solictacoes")]
    partial class solictacoes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CondominioInteligente.Models.AreaComum", b =>
                {
                    b.Property<int>("CodArea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodArea"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioCodUsuario")
                        .HasColumnType("int");

                    b.HasKey("CodArea");

                    b.HasIndex("UsuarioCodUsuario");

                    b.ToTable("AreaComum");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Documento", b =>
                {
                    b.Property<int>("CodDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodDocumento"));

                    b.Property<byte[]>("Arquivo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("CodReuniao")
                        .HasColumnType("int");

                    b.HasKey("CodDocumento");

                    b.HasIndex("CodReuniao");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Encomenda", b =>
                {
                    b.Property<int>("CodEncomenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodEncomenda"));

                    b.Property<int>("CodUsuario")
                        .HasColumnType("int");

                    b.Property<byte[]>("FotoEncomenda")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CodEncomenda");

                    b.HasIndex("CodUsuario");

                    b.ToTable("Encomenda");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Moradia", b =>
                {
                    b.Property<int>("CodMoradia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodMoradia"));

                    b.Property<int>("CodUsuario")
                        .HasColumnType("int");

                    b.Property<string>("IdentificadorMoradia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodMoradia");

                    b.HasIndex("CodUsuario");

                    b.ToTable("Moradia");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Reuniao", b =>
                {
                    b.Property<int>("CodReuniao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodReuniao"));

                    b.Property<string>("Ata")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodUsuario")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeReuniao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pauta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodReuniao");

                    b.HasIndex("CodUsuario");

                    b.ToTable("Reuniao");
                });

            modelBuilder.Entity("CondominioInteligente.Models.SolicitacaoAreaComum", b =>
                {
                    b.Property<int>("CodSolictacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodSolictacao"));

                    b.Property<int>("AreaCodArea")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioSolictanteCodUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("aprovado")
                        .HasColumnType("bit");

                    b.HasKey("CodSolictacao");

                    b.HasIndex("AreaCodArea");

                    b.HasIndex("UsuarioSolictanteCodUsuario");

                    b.ToTable("SolicitacaoAreaComum");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Usuario", b =>
                {
                    b.Property<int>("CodUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodUsuario"));

                    b.Property<bool>("Aprovado")
                        .HasColumnType("bit");

                    b.Property<int>("CodTipoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodUsuario");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("CondominioInteligente.Models.AreaComum", b =>
                {
                    b.HasOne("CondominioInteligente.Models.Usuario", null)
                        .WithMany("AreaComums")
                        .HasForeignKey("UsuarioCodUsuario");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Documento", b =>
                {
                    b.HasOne("CondominioInteligente.Models.Reuniao", "Reuniao")
                        .WithMany("Documentos")
                        .HasForeignKey("CodReuniao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reuniao");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Encomenda", b =>
                {
                    b.HasOne("CondominioInteligente.Models.Usuario", "Porteiro")
                        .WithMany("Encomendas")
                        .HasForeignKey("CodUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Porteiro");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Moradia", b =>
                {
                    b.HasOne("CondominioInteligente.Models.Usuario", "Proprietario")
                        .WithMany("Moradias")
                        .HasForeignKey("CodUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Reuniao", b =>
                {
                    b.HasOne("CondominioInteligente.Models.Usuario", "UsuarioMaster")
                        .WithMany("Reunioes")
                        .HasForeignKey("CodUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioMaster");
                });

            modelBuilder.Entity("CondominioInteligente.Models.SolicitacaoAreaComum", b =>
                {
                    b.HasOne("CondominioInteligente.Models.AreaComum", "Area")
                        .WithMany()
                        .HasForeignKey("AreaCodArea")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CondominioInteligente.Models.Usuario", "UsuarioSolictante")
                        .WithMany()
                        .HasForeignKey("UsuarioSolictanteCodUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("UsuarioSolictante");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Reuniao", b =>
                {
                    b.Navigation("Documentos");
                });

            modelBuilder.Entity("CondominioInteligente.Models.Usuario", b =>
                {
                    b.Navigation("AreaComums");

                    b.Navigation("Encomendas");

                    b.Navigation("Moradias");

                    b.Navigation("Reunioes");
                });
#pragma warning restore 612, 618
        }
    }
}
