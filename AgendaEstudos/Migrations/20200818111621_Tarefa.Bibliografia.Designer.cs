﻿// <auto-generated />
using AgendaEstudos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgendaEstudos.Migrations
{
    [DbContext(typeof(AgendaEstudosDbContext))]
    [Migration("20200818111621_Tarefa.Bibliografia")]
    partial class TarefaBibliografia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AgendaEstudos.Models.Tarefa", b =>
                {
                    b.Property<long>("TarefaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Bibligrafia")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("HorasEstudadas")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Prioridade")
                        .HasColumnType("int");

                    b.Property<string>("Unidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TarefaID");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
