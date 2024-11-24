using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionCrud.Models
{
    public class Asignatura
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        public int CalificacionesID { get; set; }


        public Calificaciones Calificaciones { get; set; }
    }
}
