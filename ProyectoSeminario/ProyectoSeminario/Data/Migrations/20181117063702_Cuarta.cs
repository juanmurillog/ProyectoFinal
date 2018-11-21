using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoSeminario.Data.Migrations
{
    public partial class Cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPagoId",
                table: "Venta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoPagoId",
                table: "Alquiler",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPagoId",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "TipoPagoId",
                table: "Alquiler");
        }
    }
}
