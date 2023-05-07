using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class inclusaoaprovacaousuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aprovado",
                table: "usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aprovado",
                table: "usuarios");
        }
    }
}
