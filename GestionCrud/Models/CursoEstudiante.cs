namespace GestionCrud.Models
{
    public class CursoEstudiante
    {
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
