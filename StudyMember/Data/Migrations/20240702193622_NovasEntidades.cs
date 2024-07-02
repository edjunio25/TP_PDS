using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyMember.Data.Migrations
{
    public partial class NovasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Faltas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<bool>(
                name: "Abonada",
                table: "Faltas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Semestres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ano = table.Column<int>(type: "INTEGER", nullable: false),
                    AlunoId = table.Column<string>(type: "TEXT", nullable: false),
                    SemestreReferencia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semestres", x => x.Id);
                    table.ForeignKey(
                        name: "SemestreAlunoFKConstraint",
                        column: x => x.AlunoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<int>(type: "INTEGER", nullable: false),
                    TempoDeEstudo = table.Column<int>(type: "INTEGER", nullable: false),
                    CargaHoraria = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusDaDisciplina = table.Column<int>(type: "INTEGER", nullable: false),
                    NotaTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    NotaTotalDistribuida = table.Column<int>(type: "INTEGER", nullable: false),
                    PercentualDeFaltasPermitidas = table.Column<float>(type: "REAL", nullable: false),
                    FaltasRestantes = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "SemestreDisciplinaFKConstraint",
                        column: x => x.Id,
                        principalTable: "Semestres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atividade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    DataDeInclusaoAtividade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataPrazoAtividade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataEntregaAtividade = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TipoDaAtividade = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusDaAtividade = table.Column<int>(type: "INTEGER", nullable: true),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    Nota = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividade", x => x.Id);
                    table.ForeignKey(
                        name: "DisciplinaAtividadeFKConstraint",
                        column: x => x.Id,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Semestres_AlunoId",
                table: "Semestres",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "DisciplinaFaltaFKConstraint",
                table: "Faltas",
                column: "Id",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "DisciplinaFaltaFKConstraint",
                table: "Faltas");

            migrationBuilder.DropTable(
                name: "Atividade");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Semestres");

            migrationBuilder.DropColumn(
                name: "Abonada",
                table: "Faltas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Faltas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
