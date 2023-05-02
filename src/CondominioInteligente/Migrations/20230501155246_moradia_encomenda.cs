using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class moradia_encomenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encomenda",
                columns: table => new
                {
                    CodEncomenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoEncomenda = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CodUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encomenda", x => x.CodEncomenda);
                    table.ForeignKey(
                        name: "FK_Encomenda_usuarios_CodUsuario",
                        column: x => x.CodUsuario,
                        principalTable: "usuarios",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moradia",
                columns: table => new
                {
                    CodMoradia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificadorMoradia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moradia", x => x.CodMoradia);
                    table.ForeignKey(
                        name: "FK_Moradia_usuarios_CodUsuario",
                        column: x => x.CodUsuario,
                        principalTable: "usuarios",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Encomenda_CodUsuario",
                table: "Encomenda",
                column: "CodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Moradia_CodUsuario",
                table: "Moradia",
                column: "CodUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encomenda");

            migrationBuilder.DropTable(
                name: "Moradia");
        }
    }
}
