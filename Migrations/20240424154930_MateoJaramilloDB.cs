using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MJPruebaProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class MateoJaramilloDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MJ_Tacos",
                columns: table => new
                {
                    TacoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MJ_NombreTaco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MJ_DescripcionDelTaco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MJ_PrecioTaco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MJ_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MJ_Tacos", x => x.TacoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MJ_Tacos");
        }
    }
}
