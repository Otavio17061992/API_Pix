using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioNet.Data.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoChave = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagador",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagador_Chave_ChaveId",
                        column: x => x.ChaveId,
                        principalTable: "Chave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recebedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recebedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recebedor_Chave_ChaveId",
                        column: x => x.ChaveId,
                        principalTable: "Chave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataTransacao = table.Column<DateTime>(type: "date", nullable: false),
                    PagadorId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PagadorId = table.Column<int>(type: "int", nullable: false),
                    RecebedorId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecebedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transacoes_Pagador_PagadorId1",
                        column: x => x.PagadorId1,
                        principalTable: "Pagador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacoes_Recebedor_RecebedorId1",
                        column: x => x.RecebedorId1,
                        principalTable: "Recebedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagador_ChaveId",
                table: "Pagador",
                column: "ChaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Recebedor_ChaveId",
                table: "Recebedor",
                column: "ChaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_PagadorId1",
                table: "Transacoes",
                column: "PagadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_RecebedorId1",
                table: "Transacoes",
                column: "RecebedorId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacoes");

            migrationBuilder.DropTable(
                name: "Pagador");

            migrationBuilder.DropTable(
                name: "Recebedor");

            migrationBuilder.DropTable(
                name: "Chave");
        }
    }
}
