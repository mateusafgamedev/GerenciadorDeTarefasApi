using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeTarefasAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjusteAtividadeEUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Atividades",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "StatusAtividade",
                table: "Atividades",
                newName: "SituacaoAtividade");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "AspNetUsers",
                newName: "ContaAtiva");

            migrationBuilder.AddColumn<int>(
                name: "NaturezaAtividade",
                table: "Atividades",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NaturezaAtividade",
                table: "Atividades");

            migrationBuilder.RenameColumn(
                name: "SituacaoAtividade",
                table: "Atividades",
                newName: "StatusAtividade");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Atividades",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "ContaAtiva",
                table: "AspNetUsers",
                newName: "Ativo");
        }
    }
}
