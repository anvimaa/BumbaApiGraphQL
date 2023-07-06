using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumbaApiGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class TraladaNV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CertificadoObito",
                table: "Transladacao",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naturalidade",
                table: "Transladacao",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "Transladacao",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomePai",
                table: "Transladacao",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProcessoConservacao",
                table: "Transladacao",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificadoObito",
                table: "Transladacao");

            migrationBuilder.DropColumn(
                name: "Naturalidade",
                table: "Transladacao");

            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "Transladacao");

            migrationBuilder.DropColumn(
                name: "NomePai",
                table: "Transladacao");

            migrationBuilder.DropColumn(
                name: "ProcessoConservacao",
                table: "Transladacao");
        }
    }
}
