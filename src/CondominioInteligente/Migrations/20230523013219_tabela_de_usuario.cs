using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class tabela_de_usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Senha",
                table: "usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "usuarios");
        }
    }
}
