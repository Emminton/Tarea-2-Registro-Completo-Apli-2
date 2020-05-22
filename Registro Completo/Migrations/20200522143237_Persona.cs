using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registro_Completo.Migrations
{
    public partial class Persona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Cedula", "Direccion", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 1, "0000024563", "Rio de janeiro #1286", new DateTime(2020, 5, 22, 10, 32, 36, 746, DateTimeKind.Local).AddTicks(6989), "Roberto Carlos", "8293567829" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
