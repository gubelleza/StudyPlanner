using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaEstudos.Migrations
{
    public partial class DataCriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CriadaEm",
                table: "Tarefas",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 20, 8, 23, 39, 644, DateTimeKind.Local).AddTicks(9448));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CriadaEm",
                table: "Tarefas");
        }
    }
}
