namespace GestionCrud.Models
{
    public class Paselista
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        public DateTime Fecha { get; set; }
        public bool Presente { get; set; }
    }
}
