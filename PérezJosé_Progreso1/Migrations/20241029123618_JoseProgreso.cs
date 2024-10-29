using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PérezJosé_Progreso1.Migrations
{
    /// <inheritdoc />
    public partial class JoseProgreso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PerezJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtributoInt = table.Column<int>(type: "int", nullable: false),
                    AtributoDecimal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AtributoString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AtributoBool = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerezJ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PerezJId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Celular_PerezJ_PerezJId",
                        column: x => x.PerezJId,
                        principalTable: "PerezJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Celular_PerezJId",
                table: "Celular",
                column: "PerezJId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Celular");

            migrationBuilder.DropTable(
                name: "PerezJ");
        }
    }
}
