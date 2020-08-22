using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaEstudos.Migrations
{
    public partial class MetaHoras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Prioridade",
                table: "Tarefas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadaEm",
                table: "Tarefas",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 21, 15, 14, 18, 455, DateTimeKind.Local).AddTicks(177),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 8, 20, 8, 35, 39, 456, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.AddColumn<double>(
                name: "MetaHoras",
                table: "Tarefas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaHoras",
                table: "Tarefas");

            migrationBuilder.AlterColumn<int>(
                name: "Prioridade",
                table: "Tarefas",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadaEm",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 20, 8, 35, 39, 456, DateTimeKind.Local).AddTicks(2232),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 21, 15, 14, 18, 455, DateTimeKind.Local).AddTicks(177));
        }
    }
}
