using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaEstudos.Migrations
{
    public partial class CriadaEmtMapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadaEm",
                table: "Tarefas",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 21, 18, 48, 36, 477, DateTimeKind.Local).AddTicks(3337),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 8, 21, 18, 44, 27, 760, DateTimeKind.Local).AddTicks(7033));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CriadaEm",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 21, 18, 44, 27, 760, DateTimeKind.Local).AddTicks(7033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 21, 18, 48, 36, 477, DateTimeKind.Local).AddTicks(3337));
        }
    }
}
