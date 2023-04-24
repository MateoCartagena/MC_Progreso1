using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Progreso1.Migrations
{
    public partial class MateoCartgena2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "McSegundoNombre",
                table: "MCartagena",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McCedula",
                table: "MCartagena",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "McCedula",
                table: "MCartagena");

            migrationBuilder.AlterColumn<string>(
                name: "McSegundoNombre",
                table: "MCartagena",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }
    }
}
