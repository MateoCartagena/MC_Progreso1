using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Progreso1.Migrations
{
    public partial class MateoCartagena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MCartagena",
                columns: table => new
                {
                    McID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    McPromedioGlobal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    McSegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    McSoltero = table.Column<bool>(type: "bit", nullable: false),
                    McFechaHoy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCartagena", x => x.McID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MCartagena");
        }
    }
}
