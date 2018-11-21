using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoSeminario.Data.Migrations
{
    public partial class tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NombreTipoProducto",
                table: "TipoProducto",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 40);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NombreTipoProducto",
                table: "TipoProducto",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);
        }
    }
}
