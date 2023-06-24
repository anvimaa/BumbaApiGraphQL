using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumbaApiGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CemiterioId",
                table: "Defuntos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NomeParente",
                table: "Defuntos",
                type: "TEXT",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TerminalParente",
                table: "Defuntos",
                type: "TEXT",
                maxLength: 150,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Defuntos_CemiterioId",
                table: "Defuntos",
                column: "CemiterioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Defuntos_Cemiterios_CemiterioId",
                table: "Defuntos",
                column: "CemiterioId",
                principalTable: "Cemiterios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Defuntos_Cemiterios_CemiterioId",
                table: "Defuntos");

            migrationBuilder.DropIndex(
                name: "IX_Defuntos_CemiterioId",
                table: "Defuntos");

            migrationBuilder.DropColumn(
                name: "CemiterioId",
                table: "Defuntos");

            migrationBuilder.DropColumn(
                name: "NomeParente",
                table: "Defuntos");

            migrationBuilder.DropColumn(
                name: "TerminalParente",
                table: "Defuntos");
        }
    }
}
