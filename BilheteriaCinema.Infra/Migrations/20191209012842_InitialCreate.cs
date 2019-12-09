using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilheteriaCinema.Infra.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Filme",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 120, nullable: false),
                    Codigo = table.Column<int>(nullable: false),
                    Duracao = table.Column<TimeSpan>(nullable: false),
                    FaixaEtaria = table.Column<int>(nullable: false),
                    Genero = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sala",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 240, nullable: false),
                    Codigo = table.Column<int>(nullable: false),
                    Lugares = table.Column<int>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessao",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 240, nullable: false),
                    Codigo = table.Column<int>(nullable: false),
                    Horario = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    CodigoSala = table.Column<int>(nullable: false),
                    SalaId = table.Column<int>(nullable: true),
                    CodigoFilme = table.Column<int>(nullable: false),
                    FilmeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessao_Filme_FilmeId",
                        column: x => x.FilmeId,
                        principalSchema: "dbo",
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessao_Sala_SalaId",
                        column: x => x.SalaId,
                        principalSchema: "dbo",
                        principalTable: "Sala",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingresso",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<int>(nullable: false),
                    CPF = table.Column<string>(maxLength: 11, nullable: false),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    ValorPago = table.Column<decimal>(nullable: false),
                    Observacao = table.Column<string>(maxLength: 240, nullable: false),
                    CodigoSessao = table.Column<int>(nullable: false),
                    SessaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingresso_Sessao_SessaoId",
                        column: x => x.SessaoId,
                        principalSchema: "dbo",
                        principalTable: "Sessao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filme_Codigo",
                schema: "dbo",
                table: "Filme",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Filme_Id",
                schema: "dbo",
                table: "Filme",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingresso_Codigo",
                schema: "dbo",
                table: "Ingresso",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingresso_Id",
                schema: "dbo",
                table: "Ingresso",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingresso_SessaoId",
                schema: "dbo",
                table: "Ingresso",
                column: "SessaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sala_Codigo",
                schema: "dbo",
                table: "Sala",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sala_Id",
                schema: "dbo",
                table: "Sala",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_Codigo",
                schema: "dbo",
                table: "Sessao",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_FilmeId",
                schema: "dbo",
                table: "Sessao",
                column: "FilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_Id",
                schema: "dbo",
                table: "Sessao",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_SalaId",
                schema: "dbo",
                table: "Sessao",
                column: "SalaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingresso",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sessao",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Filme",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sala",
                schema: "dbo");
        }
    }
}
