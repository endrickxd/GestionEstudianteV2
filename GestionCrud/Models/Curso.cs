namespace GestionCrud.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<CursoEstudiante> Estudiantes { get; set; }
    }
}
