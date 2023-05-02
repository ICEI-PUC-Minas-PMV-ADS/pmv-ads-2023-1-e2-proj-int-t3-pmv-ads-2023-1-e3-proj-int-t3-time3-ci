using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class reuniao_docucmento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reuniao",
                columns: table => new
                {
                    CodReuniao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeReuniao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pauta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ata = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reuniao", x => x.CodReuniao);
                    table.ForeignKey(
                        name: "FK_Reuniao_usuarios_CodUsuario",
                        column: x => x.CodUsuario,
                        principalTable: "usuarios",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    CodDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Arquivo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CodReuniao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.CodDocumento);
                    table.ForeignKey(
                        name: "FK_Documento_Reuniao_CodReuniao",
                        column: x => x.CodReuniao,
                        principalTable: "Reuniao",
                        principalColumn: "CodReuniao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documento_CodReuniao",
                table: "Documento",
                column: "CodReuniao");

            migrationBuilder.CreateIndex(
                name: "IX_Reuniao_CodUsuario",
                table: "Reuniao",
                column: "CodUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Reuniao");
        }
    }
}
