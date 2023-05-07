using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class solictacoesajusteusuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitacaoAreaComum_usuarios_UsuarioSolictanteCodUsuario",
                table: "SolicitacaoAreaComum");

            migrationBuilder.RenameColumn(
                name: "UsuarioSolictanteCodUsuario",
                table: "SolicitacaoAreaComum",
                newName: "CodUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitacaoAreaComum_UsuarioSolictanteCodUsuario",
                table: "SolicitacaoAreaComum",
                newName: "IX_SolicitacaoAreaComum_CodUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitacaoAreaComum_usuarios_CodUsuario",
                table: "SolicitacaoAreaComum",
                column: "CodUsuario",
                principalTable: "usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitacaoAreaComum_usuarios_CodUsuario",
                table: "SolicitacaoAreaComum");

            migrationBuilder.RenameColumn(
                name: "CodUsuario",
                table: "SolicitacaoAreaComum",
                newName: "UsuarioSolictanteCodUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitacaoAreaComum_CodUsuario",
                table: "SolicitacaoAreaComum",
                newName: "IX_SolicitacaoAreaComum_UsuarioSolictanteCodUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitacaoAreaComum_usuarios_UsuarioSolictanteCodUsuario",
                table: "SolicitacaoAreaComum",
                column: "UsuarioSolictanteCodUsuario",
                principalTable: "usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
