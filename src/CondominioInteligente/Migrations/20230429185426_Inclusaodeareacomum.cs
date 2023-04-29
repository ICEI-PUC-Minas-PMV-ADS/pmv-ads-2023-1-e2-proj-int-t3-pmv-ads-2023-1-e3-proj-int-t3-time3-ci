using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class Inclusaodeareacomum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cod_Tipo_Usuario",
                table: "usuarios",
                newName: "CodTipoUsuario");

            migrationBuilder.RenameColumn(
                name: "Cod_Usuario",
                table: "usuarios",
                newName: "CodUsuario");

            migrationBuilder.CreateTable(
                name: "AreaComum",
                columns: table => new
                {
                    CodArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCodUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaComum", x => x.CodArea);
                    table.ForeignKey(
                        name: "FK_AreaComum_usuarios_UsuarioCodUsuario",
                        column: x => x.UsuarioCodUsuario,
                        principalTable: "usuarios",
                        principalColumn: "CodUsuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaComum_UsuarioCodUsuario",
                table: "AreaComum",
                column: "UsuarioCodUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaComum");

            migrationBuilder.RenameColumn(
                name: "CodTipoUsuario",
                table: "usuarios",
                newName: "Cod_Tipo_Usuario");

            migrationBuilder.RenameColumn(
                name: "CodUsuario",
                table: "usuarios",
                newName: "Cod_Usuario");
        }
    }
}
