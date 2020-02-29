using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EsteticaBackend.Migrations
{
    public partial class AtendimentoeProcedimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "ProfissionalId",
                table: "Pessoa");

            migrationBuilder.CreateTable(
                name: "Procedimento",
                columns: table => new
                {
                    ProcedimentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Valor = table.Column<float>(nullable: false),
                    Duração = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimento", x => x.ProcedimentoId);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    AtendimentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProcedimentoId = table.Column<int>(nullable: true),
                    DataMarcada = table.Column<DateTime>(nullable: false),
                    ClientePessoaId = table.Column<int>(nullable: true),
                    ProfissionalPessoaId = table.Column<int>(nullable: true),
                    Cancelado = table.Column<bool>(nullable: false),
                    Finalizado = table.Column<bool>(nullable: false),
                    EmAndamento = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.AtendimentoId);
                    table.ForeignKey(
                        name: "FK_Atendimento_Pessoa_ClientePessoaId",
                        column: x => x.ClientePessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atendimento_Procedimento_ProcedimentoId",
                        column: x => x.ProcedimentoId,
                        principalTable: "Procedimento",
                        principalColumn: "ProcedimentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atendimento_Pessoa_ProfissionalPessoaId",
                        column: x => x.ProfissionalPessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ClientePessoaId",
                table: "Atendimento",
                column: "ClientePessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ProcedimentoId",
                table: "Atendimento",
                column: "ProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ProfissionalPessoaId",
                table: "Atendimento",
                column: "ProfissionalPessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Procedimento");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfissionalId",
                table: "Pessoa",
                nullable: true);
        }
    }
}
