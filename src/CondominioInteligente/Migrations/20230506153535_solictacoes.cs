using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class solictacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolicitacaoAreaComum",
                columns: table => new
                {
                    CodSolictacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioSolictanteCodUsuario = table.Column<int>(type: "int", nullable: false),
                    AreaCodArea = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    aprovado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoAreaComum", x => x.CodSolictacao);
                    table.ForeignKey(
                        name: "FK_SolicitacaoAreaComum_AreaComum_AreaCodArea",
                        column: x => x.AreaCodArea,
                        principalTable: "AreaComum",
                        principalColumn: "CodArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoAreaComum_usuarios_UsuarioSolictanteCodUsuario",
                        column: x => x.UsuarioSolictanteCodUsuario,
                        principalTable: "usuarios",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoAreaComum_AreaCodArea",
                table: "SolicitacaoAreaComum",
                column: "AreaCodArea");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoAreaComum_UsuarioSolictanteCodUsuario",
                table: "SolicitacaoAreaComum",
                column: "UsuarioSolictanteCodUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolicitacaoAreaComum");
        }
    }
}
