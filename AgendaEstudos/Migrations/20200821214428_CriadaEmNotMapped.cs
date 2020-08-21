using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaEstudos.Migrations
{
    public partial class CriadaEmNotMapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MetaHoras",
                table: "Tarefas",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadaEm",
                table: "Tarefas",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 21, 18, 44, 27, 760, DateTimeKind.Local).AddTicks(7033),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 8, 21, 15, 14, 18, 455, DateTimeKind.Local).AddTicks(177));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MetaHoras",
                table: "Tarefas",
                type: "double",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadaEm",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 21, 15, 14, 18, 455, DateTimeKind.Local).AddTicks(177),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 21, 18, 44, 27, 760, DateTimeKind.Local).AddTicks(7033));
        }
    }
}
