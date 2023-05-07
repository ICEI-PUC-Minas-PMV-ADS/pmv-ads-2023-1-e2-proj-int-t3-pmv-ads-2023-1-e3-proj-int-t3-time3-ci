using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioInteligente.Migrations
{
    /// <inheritdoc />
    public partial class aprovadoopcicional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "aprovado",
                table: "SolicitacaoAreaComum",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "aprovado",
                table: "SolicitacaoAreaComum",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
