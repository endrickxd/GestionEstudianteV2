using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionCrud.Models
{
    public class Estudiantes
    {



        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        public int AsignaturaID { get; set; }
        [ForeignKey("AsignaturaID")]
        public int CalificacionID { get; set; }
        [ForeignKey("CalificacionID")]
        public Asignatura Asignatura { get; set; }
        public Calificaciones Calificacion { get; set; }


    }
}
