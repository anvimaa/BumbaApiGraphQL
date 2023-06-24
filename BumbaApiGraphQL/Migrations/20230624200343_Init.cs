using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumbaApiGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defuntos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataFalecimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataEnterro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataCadastramento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NomeCompleto = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TipoIdentidade = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NumeroIdentidade = table.Column<string>(type: "TEXT", maxLength: 14, nullable: false),
                    Genero = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defuntos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proprietarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCadastramento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NomeCompleto = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TipoIdentidade = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NumeroIdentidade = table.Column<string>(type: "TEXT", maxLength: 14, nullable: false),
                    Genero = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    DataCadastramento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DataCadastramento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProvinciaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastramento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipios_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cemiterios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Responsavel = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    MunicipioId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastramento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cemiterios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cemiterios_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MunicipioId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastramento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NomeCompleto = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TipoIdentidade = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NumeroIdentidade = table.Column<string>(type: "TEXT", maxLength: 14, nullable: false),
                    Genero = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utentes_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cemiterios_MunicipioId",
                table: "Cemiterios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_ProvinciaId",
                table: "Municipios",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Utentes_MunicipioId",
                table: "Utentes",
                column: "MunicipioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cemiterios");

            migrationBuilder.DropTable(
                name: "Defuntos");

            migrationBuilder.DropTable(
                name: "Proprietarios");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Utentes");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Provincias");
        }
    }
}
