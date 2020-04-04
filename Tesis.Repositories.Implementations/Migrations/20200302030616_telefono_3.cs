using Microsoft.EntityFrameworkCore.Migrations;

namespace Tesis.Repositories.Implementation.Migrations
{
    public partial class telefono_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Clientes_Cliente_ID",
                table: "Telefonos");

            migrationBuilder.RenameColumn(
                name: "Cliente_ID",
                table: "Telefonos",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Telefonos_Cliente_ID",
                table: "Telefonos",
                newName: "IX_Telefonos_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Clientes_ClienteID",
                table: "Telefonos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Clientes_ClienteID",
                table: "Telefonos");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Telefonos",
                newName: "Cliente_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Telefonos_ClienteID",
                table: "Telefonos",
                newName: "IX_Telefonos_Cliente_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Clientes_Cliente_ID",
                table: "Telefonos",
                column: "Cliente_ID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
