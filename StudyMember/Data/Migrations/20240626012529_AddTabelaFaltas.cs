using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyMember.Data.Migrations
{
    public partial class AddTabelaFaltas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faltas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataFalta = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataDeRegistro = table.Column<DateTime>(type: "TEXT", nullable: true),
                    HoraAula = table.Column<int>(type: "INTEGER", nullable: true),
                    Justificativa = table.Column<string>(type: "TEXT", nullable: true),
                    LinkAnexo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faltas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faltas");
        }
    }
}
