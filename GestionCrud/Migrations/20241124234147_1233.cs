using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionCrud.Migrations
{
    public partial class _1233 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "EstudianteID");

            migrationBuilder.RenameIndex(
                name: "IX_Profesor_EstudianteIDID",
                table: "Profesor",
                newName: "IX_Profesor_EstudianteID");

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
                name: "CalificacionID",
                table: "Estudiantes",
                type: "int",
                nullable: true);

     

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Asignaturas_CalificacionID",
                table: "Estudiantes",
                column: "CalificacionID",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Calificaciones_CalificacionID",
                table: "Estudiantes",
                column: "CalificacionID",
                principalTable: "Calificaciones",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesor_Estudiantes_EstudianteID",
                table: "Profesor",
                column: "EstudianteID",
                principalTable: "Estudiantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Asignaturas_CalificacionID",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Calificaciones_CalificacionID",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesor_Estudiantes_EstudianteID",
                table: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_CalificacionID",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "CalificacionID",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "EstudianteID",
                table: "Profesor",
                newName: "EstudianteIDID");

            migrationBuilder.RenameIndex(
                name: "IX_Profesor_EstudianteID",
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
    }
}
