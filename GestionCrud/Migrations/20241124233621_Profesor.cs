using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionCrud.Migrations
{
    public partial class Profesor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstudianteID",
                table: "Profesor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstudiantesID",
                table: "Profesor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalificacionesID",
                table: "Asignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_EstudiantesID",
                table: "Profesor",
                column: "EstudiantesID");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_CalificacionesID",
                table: "Asignaturas",
                column: "CalificacionesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Calificaciones_CalificacionesID",
                table: "Asignaturas",
                column: "CalificacionesID",
                principalTable: "Calificaciones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesor_Estudiantes_EstudiantesID",
                table: "Profesor",
                column: "EstudiantesID",
                principalTable: "Estudiantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Calificaciones_CalificacionesID",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesor_Estudiantes_EstudiantesID",
                table: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Profesor_EstudiantesID",
                table: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Asignaturas_CalificacionesID",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "EstudianteID",
                table: "Profesor");

            migrationBuilder.DropColumn(
                name: "EstudiantesID",
                table: "Profesor");

            migrationBuilder.DropColumn(
                name: "CalificacionesID",
                table: "Asignaturas");
        }
    }
}
