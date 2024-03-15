﻿// <auto-generated />
using System;
using COMTUR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace COMTUR.Migrations
{
    [DbContext(typeof(ComturDBContext))]
    partial class ComturDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("COMTUR.Models.AtracaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("atracaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<int>("IdTipoAtracao")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("qrcode");

                    b.Property<int?>("TipoAtracaoModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoAtracao");

                    b.HasIndex("TipoAtracaoModelId");

                    b.ToTable("atracao");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("empresaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("CNPJ")
                        .HasColumnType("bigint")
                        .HasColumnName("cnpj");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    b.Property<string>("Imagem")
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("empresa");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemAtracaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("imagematracaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IdAtracao")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.HasKey("Id");

                    b.HasIndex("IdAtracao");

                    b.ToTable("imagematracao");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemNoticiaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("imagemnoticiaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IdNoticia")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.HasKey("Id");

                    b.HasIndex("IdNoticia");

                    b.ToTable("imagemnoticia");
                });

            modelBuilder.Entity("COMTUR.Models.NoticiaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("noticiaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("conteudo");

                    b.Property<DateOnly>("DataPublicacao")
                        .HasColumnType("date")
                        .HasColumnName("datapublicacao");

                    b.Property<string>("HoraPublicacao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("horaPublicacao");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.Property<string>("Subtitulo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("subtitulo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.ToTable("noticia");
                });

            modelBuilder.Entity("COMTUR.Models.TipoAtracaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipoatracaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipoatracao");
                });

            modelBuilder.Entity("COMTUR.Models.TipoTurismoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipoturismoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipoturismo");
                });

            modelBuilder.Entity("COMTUR.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("emailUsuario");

                    b.Property<string>("ImagemPerfilUsuario")
                        .HasColumnType("text")
                        .HasColumnName("imagemPerfilUsuario");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senhaUsuario");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("integer")
                        .HasColumnName("tipoUsuario");

                    b.HasKey("Id");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("COMTUR.Models.AtracaoModel", b =>
                {
                    b.HasOne("COMTUR.Models.TipoAtracaoModel", "TipoAtracaoModel")
                        .WithMany()
                        .HasForeignKey("IdTipoAtracao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMTUR.Models.TipoAtracaoModel", null)
                        .WithMany("Atracao")
                        .HasForeignKey("TipoAtracaoModelId");

                    b.Navigation("TipoAtracaoModel");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresaModel", b =>
                {
                    b.HasOne("COMTUR.Models.UsuarioModel", "UsuarioModel")
                        .WithMany("Empresas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioModel");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemAtracaoModel", b =>
                {
                    b.HasOne("COMTUR.Models.AtracaoModel", "AtracaoModel")
                        .WithMany("ImagemAtracao")
                        .HasForeignKey("IdAtracao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AtracaoModel");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemNoticiaModel", b =>
                {
                    b.HasOne("COMTUR.Models.NoticiaModel", "NoticiaModel")
                        .WithMany("ImagemNoticia")
                        .HasForeignKey("IdNoticia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NoticiaModel");
                });

            modelBuilder.Entity("COMTUR.Models.AtracaoModel", b =>
                {
                    b.Navigation("ImagemAtracao");
                });

            modelBuilder.Entity("COMTUR.Models.NoticiaModel", b =>
                {
                    b.Navigation("ImagemNoticia");
                });

            modelBuilder.Entity("COMTUR.Models.TipoAtracaoModel", b =>
                {
                    b.Navigation("Atracao");
                });

            modelBuilder.Entity("COMTUR.Models.UsuarioModel", b =>
                {
                    b.Navigation("Empresas");
                });
#pragma warning restore 612, 618
        }
    }
}
