using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class solictacoesajuste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitacaoAreaComum_AreaComum_AreaCodArea",
                table: "SolicitacaoAreaComum");

            migrationBuilder.RenameColumn(
                name: "AreaCodArea",
                table: "SolicitacaoAreaComum",
                newName: "CodArea");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitacaoAreaComum_AreaCodArea",
                table: "SolicitacaoAreaComum",
                newName: "IX_SolicitacaoAreaComum_CodArea");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitacaoAreaComum_AreaComum_CodArea",
                table: "SolicitacaoAreaComum",
                column: "CodArea",
                principalTable: "AreaComum",
                principalColumn: "CodArea",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitacaoAreaComum_AreaComum_CodArea",
                table: "SolicitacaoAreaComum");

            migrationBuilder.RenameColumn(
                name: "CodArea",
                table: "SolicitacaoAreaComum",
                newName: "AreaCodArea");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitacaoAreaComum_CodArea",
                table: "SolicitacaoAreaComum",
                newName: "IX_SolicitacaoAreaComum_AreaCodArea");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitacaoAreaComum_AreaComum_AreaCodArea",
                table: "SolicitacaoAreaComum",
                column: "AreaCodArea",
                principalTable: "AreaComum",
                principalColumn: "CodArea",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
