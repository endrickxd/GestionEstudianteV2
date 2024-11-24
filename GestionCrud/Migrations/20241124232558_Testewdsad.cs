using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionCrud.Migrations
{
    public partial class Testewdsad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AsignaturaID",
                table: "Estudiantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalificacionID",
                table: "Estudiantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalificacionID1",
                table: "Estudiantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_CalificacionID",
                table: "Estudiantes",
                column: "CalificacionID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Asignaturas_CalificacionID",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Calificaciones_CalificacionID1",
                table: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_CalificacionID",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_CalificacionID1",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "AsignaturaID",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "CalificacionID",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "CalificacionID1",
                table: "Estudiantes");
        }
    }
}
