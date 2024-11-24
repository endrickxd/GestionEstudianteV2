using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionCrud.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Asignaturas_CalificacionID",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Calificaciones_CalificacionID1",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesor_Estudiantes_EstudiantesID",
                table: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_CalificacionID1",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "EstudianteID",
                table: "Profesor");

            migrationBuilder.DropColumn(
                name: "CalificacionID1",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "EstudiantesID",
                table: "Profesor",
                newName: "EstudianteIDID");

            migrationBuilder.RenameIndex(
                name: "IX_Profesor_EstudiantesID",
                table: "Profesor",
                newName: "IX_Profesor_EstudianteIDID");

            migrationBuilder.RenameColumn(
                name: "CalificacionID",
                table: "Estudiantes",
                newName: "CalificacionIDID");

            migrationBuilder.RenameColumn(
                name: "AsignaturaID",
                table: "Estudiantes",
                newName: "AsignaturaIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Estudiantes_CalificacionID",
                table: "Estudiantes",
                newName: "IX_Estudiantes_CalificacionIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_AsignaturaIDId",
                table: "Estudiantes",
                column: "AsignaturaIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Asignaturas_AsignaturaIDId",
                table: "Estudiantes",
                column: "AsignaturaIDId",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Calificaciones_CalificacionIDID",
                table: "Estudiantes",
                column: "CalificacionIDID",
                principalTable: "Calificaciones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesor_Estudiantes_EstudianteIDID",
                table: "Profesor",
                column: "EstudianteIDID",
                principalTable: "Estudiantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Asignaturas_AsignaturaIDId",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Calificaciones_CalificacionIDID",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesor_Estudiantes_EstudianteIDID",
                table: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_AsignaturaIDId",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "EstudianteIDID",
                table: "Profesor",
                newName: "EstudiantesID");

            migrationBuilder.RenameIndex(
                name: "IX_Profesor_EstudianteIDID",
                table: "Profesor",
                newName: "IX_Profesor_EstudiantesID");

            migrationBuilder.RenameColumn(
                name: "CalificacionIDID",
                table: "Estudiantes",
                newName: "CalificacionID");

            migrationBuilder.RenameColumn(
                name: "AsignaturaIDId",
                table: "Estudiantes",
                newName: "AsignaturaID");

            migrationBuilder.RenameIndex(
                name: "IX_Estudiantes_CalificacionIDID",
                table: "Estudiantes",
                newName: "IX_Estudiantes_CalificacionID");

            migrationBuilder.AddColumn<int>(
                name: "EstudianteID",
                table: "Profesor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalificacionID1",
                table: "Estudiantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_CalificacionID1",
                table: "Estudiantes",
                column: "CalificacionID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Asignaturas_CalificacionID",
                table: "Estudiantes",
                column: "CalificacionID",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Calificaciones_CalificacionID1",
                table: "Estudiantes",
                column: "CalificacionID1",
                principalTable: "Calificaciones",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesor_Estudiantes_EstudiantesID",
                table: "Profesor",
                column: "EstudiantesID",
                principalTable: "Estudiantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
