namespace GestionCrud.Models
{
    public class Asignatura
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Calificacion> Calificaciones { get; set; }
    }
}
