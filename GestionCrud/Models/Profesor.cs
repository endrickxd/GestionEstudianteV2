using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionCrud.Models
{
    public class Profesor
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumeroTelefono { get; set; }

        public int EstudianteID { get; set; }

        public Estudiantes Estudiante { get; set; }


    }
}
