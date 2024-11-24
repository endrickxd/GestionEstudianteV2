namespace GestionCrud.Models
{
    public class Calificacion
    {

        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        public int AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }
        public decimal Nota { get; set; }
        public string Literal { get; set; }
    }
}
