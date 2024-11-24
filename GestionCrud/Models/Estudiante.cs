namespace GestionCrud.Models
{
    public class Estudiante
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public ICollection<CursoEstudiante> Cursos { get; set; }
    }
}
