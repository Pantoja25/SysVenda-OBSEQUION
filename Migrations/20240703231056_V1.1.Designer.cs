﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SysVenda_OBSEQUION;

#nullable disable

namespace SysVenda_OBSEQUION.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240703231056_V1.1")]
    partial class V11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("SysVenda_OBSEQUION.entidades.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Fone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SysVenda_OBSEQUION.entidades.ItemVenda", b =>
                {
                    b.Property<int>("ItemVendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ItemVendaId"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImagemURL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("QuantidadeEmEstoque")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ItemVendaId");

                    b.ToTable("ItensVendas");
                });

            modelBuilder.Entity("SysVenda_OBSEQUION.entidades.Produtos", b =>
                {
                    b.Property<int>("ProdutosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProdutosId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProdutosId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SysVenda_OBSEQUION.entidades.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SysVenda_OBSEQUION.entidades.Venda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("VendaId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("ClinteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("VendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("SysVenda_OBSEQUION.entidades.Venda", b =>
                {
                    b.HasOne("SysVenda_OBSEQUION.entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SysVenda_OBSEQUION.entidades.Produtos", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
