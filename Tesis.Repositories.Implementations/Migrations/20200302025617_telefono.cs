using Microsoft.EntityFrameworkCore.Migrations;

namespace Tesis.Repositories.Implementation.Migrations
{
    public partial class telefono : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Telefonos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Telefonos");
        }
    }
}
