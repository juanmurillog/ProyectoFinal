using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoSeminario.Data.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalVenta",
                table: "Venta",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipoServicio",
                table: "TipoServicio",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionTipoServicio",
                table: "TipoServicio",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionTipoProducto",
                table: "TipoProducto",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipoPersona",
                table: "TipoPersona",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipoPago",
                table: "TipoPago",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<double>(
                name: "ValorProducto",
                table: "Producto",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NombreProducto",
                table: "Producto",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionProducto",
                table: "Producto",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePersona",
                table: "Persona",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Persona",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Persona",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 40);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalVenta",
                table: "Venta",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "NombreTipoServicio",
                table: "TipoServicio",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "DescripcionTipoServicio",
                table: "TipoServicio",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "DescripcionTipoProducto",
                table: "TipoProducto",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "NombreTipoPersona",
                table: "TipoPersona",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "NombreTipoPago",
                table: "TipoPago",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "ValorProducto",
                table: "Producto",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "NombreProducto",
                table: "Producto",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "DescripcionProducto",
                table: "Producto",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<int>(
                name: "NombrePersona",
                table: "Persona",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "Correo",
                table: "Persona",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "Apellido",
                table: "Persona",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);
        }
    }
}
