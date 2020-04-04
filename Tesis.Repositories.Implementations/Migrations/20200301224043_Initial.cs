using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tesis.Repositories.Implementation.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    CUIL = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FechaDeNacimiento = table.Column<DateTime>(nullable: false),
                    Localidad = table.Column<string>(nullable: true),
                    Barrio = table.Column<string>(nullable: true),
                    Calle = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: true),
                    Lote = table.Column<int>(nullable: true),
                    Manzana = table.Column<int>(nullable: true),
                    Piso = table.Column<int>(nullable: true),
                    Depto = table.Column<string>(nullable: true),
                    NroCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EstadoDeCredito",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false, defaultValue: false),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoDeCredito", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false, defaultValue: false),
                    TasaMora = table.Column<decimal>(nullable: false),
                    TEM = table.Column<decimal>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeMovimiento",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false, defaultValue: false),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeMovimiento", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false, defaultValue: false),
                    Numero = table.Column<long>(nullable: false),
                    Cliente_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Telefonos_Clientes_Cliente_ID",
                        column: x => x.Cliente_ID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Trabajos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false, defaultValue: false),
                    LugarDeTrabajo = table.Column<string>(nullable: true),
                    CUIT = table.Column<long>(nullable: true),
                    Sueldo = table.Column<decimal>(nullable: false),
                    Cargo = table.Column<string>(nullable: true),
                    FechaDeIngreso = table.Column<DateTime>(nullable: false),
                    Localidad = table.Column<string>(nullable: true),
                    Barrio = table.Column<string>(nullable: true),
                    Calle = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: true),
                    Lote = table.Column<int>(nullable: true),
                    Manzana = table.Column<int>(nullable: true),
                    Piso = table.Column<int>(nullable: true),
                    Depto = table.Column<string>(nullable: true),
                    TelefonoLaboral = table.Column<long>(nullable: false),
                    ClienteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trabajos_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Creditos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false, defaultValue: false),
                    GastosAdministrativos = table.Column<decimal>(nullable: false),
                    FechaAlta = table.Column<DateTime>(nullable: false),
                    EstadoDeCreditoID = table.Column<int>(nullable: false),
                    PropietarioID = table.Column<int>(nullable: false),
                    GaranteID = table.Column<int>(nullable: false),
                    ParametroID = table.Column<int>(nullable: false),
                    SituacionCrediticia = table.Column<int>(nullable: true),
                    MontoSolicitado = table.Column<decimal>(nullable: false),
                    NroCredito = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creditos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Creditos_EstadoDeCredito_EstadoDeCreditoID",
                        column: x => x.EstadoDeCreditoID,
                        principalTable: "EstadoDeCredito",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Creditos_Clientes_GaranteID",
                        column: x => x.GaranteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Creditos_Parametros_ParametroID",
                        column: x => x.ParametroID,
                        principalTable: "Parametros",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Creditos_Clientes_PropietarioID",
                        column: x => x.PropietarioID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false, defaultValue: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    TipoId = table.Column<int>(nullable: false),
                    Concepto = table.Column<string>(nullable: true),
                    Monto = table.Column<decimal>(nullable: false),
                    Saldo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Movimientos_TiposDeMovimiento_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposDeMovimiento",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cuotas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false, defaultValue: false),
                    Numero = table.Column<int>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false),
                    MontoPorMora = table.Column<decimal>(nullable: false),
                    Interes = table.Column<decimal>(nullable: false),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    FechaDePago = table.Column<DateTime>(nullable: true),
                    Pagada = table.Column<bool>(nullable: false, defaultValue: false),
                    Credito_ID = table.Column<int>(nullable: false),
                    DiasDeMora = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuotas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cuotas_Creditos_Credito_ID",
                        column: x => x.Credito_ID,
                        principalTable: "Creditos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GaranteEnCredito",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baja = table.Column<bool>(nullable: false),
                    GaranteID = table.Column<int>(nullable: false),
                    CreditoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaranteEnCredito", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GaranteEnCredito_Creditos_CreditoID",
                        column: x => x.CreditoID,
                        principalTable: "Creditos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GaranteEnCredito_Clientes_GaranteID",
                        column: x => x.GaranteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "EstadoDeCredito",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 1, "Pendiente De Aprobar" });

            migrationBuilder.InsertData(
                table: "EstadoDeCredito",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 2, "Listo Para Aprobar" });

            migrationBuilder.InsertData(
                table: "EstadoDeCredito",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 3, "Aprobado" });

            migrationBuilder.InsertData(
                table: "EstadoDeCredito",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 4, "Otorgado" });

            migrationBuilder.InsertData(
                table: "EstadoDeCredito",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 5, "Cancelado" });

            migrationBuilder.InsertData(
                table: "EstadoDeCredito",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 6, "Rechazado" });

            migrationBuilder.InsertData(
                table: "EstadoDeCredito",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 7, "Anulado" });

            migrationBuilder.InsertData(
                table: "TiposDeMovimiento",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 1, "Debe" });

            migrationBuilder.InsertData(
                table: "TiposDeMovimiento",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 2, "Haber" });

            migrationBuilder.CreateIndex(
                name: "IX_Creditos_EstadoDeCreditoID",
                table: "Creditos",
                column: "EstadoDeCreditoID");

            migrationBuilder.CreateIndex(
                name: "IX_Creditos_GaranteID",
                table: "Creditos",
                column: "GaranteID");

            migrationBuilder.CreateIndex(
                name: "IX_Creditos_ParametroID",
                table: "Creditos",
                column: "ParametroID");

            migrationBuilder.CreateIndex(
                name: "IX_Creditos_PropietarioID",
                table: "Creditos",
                column: "PropietarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_Credito_ID",
                table: "Cuotas",
                column: "Credito_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GaranteEnCredito_CreditoID",
                table: "GaranteEnCredito",
                column: "CreditoID");

            migrationBuilder.CreateIndex(
                name: "IX_GaranteEnCredito_GaranteID",
                table: "GaranteEnCredito",
                column: "GaranteID");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_TipoId",
                table: "Movimientos",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_Cliente_ID",
                table: "Telefonos",
                column: "Cliente_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajos_ClienteID",
                table: "Trabajos",
                column: "ClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuotas");

            migrationBuilder.DropTable(
                name: "GaranteEnCredito");

            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "Trabajos");

            migrationBuilder.DropTable(
                name: "Creditos");

            migrationBuilder.DropTable(
                name: "TiposDeMovimiento");

            migrationBuilder.DropTable(
                name: "EstadoDeCredito");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Parametros");
        }
    }
}
