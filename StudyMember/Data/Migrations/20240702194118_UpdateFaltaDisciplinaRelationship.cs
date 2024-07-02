using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyMember.Data.Migrations
{
    public partial class UpdateFaltaDisciplinaRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "DisciplinaFaltaFKConstraint",
                table: "Faltas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Faltas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Faltas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faltas_DisciplinaId",
                table: "Faltas",
                column: "DisciplinaId");

            migrationBuilder.AddForeignKey(
                name: "DisciplinaFaltaFKConstraint",
                table: "Faltas",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "DisciplinaFaltaFKConstraint",
                table: "Faltas");

            migrationBuilder.DropIndex(
                name: "IX_Faltas_DisciplinaId",
                table: "Faltas");

            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Faltas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Faltas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "DisciplinaFaltaFKConstraint",
                table: "Faltas",
                column: "Id",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
