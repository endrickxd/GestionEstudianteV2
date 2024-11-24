using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionCrud.Models
{
    public class Calificaciones
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Nota { get; set; }
    
        public char Literal { get; set; }


     

    }
}
