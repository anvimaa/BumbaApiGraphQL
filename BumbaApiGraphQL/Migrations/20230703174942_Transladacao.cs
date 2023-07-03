using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumbaApiGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class Transladacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transladacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Responsavel = table.Column<string>(type: "TEXT", nullable: true),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    DataFalecimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataEnterro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorPago = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsTransladacao = table.Column<bool>(type: "INTEGER", nullable: false),
                    CemiterioId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastramento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transladacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transladacao_Cemiterios_CemiterioId",
                        column: x => x.CemiterioId,
                        principalTable: "Cemiterios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transladacao_CemiterioId",
                table: "Transladacao",
                column: "CemiterioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transladacao");
        }
    }
}
