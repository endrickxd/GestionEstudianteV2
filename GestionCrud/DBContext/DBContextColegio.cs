using GestionCrud.Models;
using Microsoft.EntityFrameworkCore;



namespace GestionCrud.DBContext
{
    public class DBContextColegio:DbContext
    {

        public DBContextColegio(DbContextOptions<DBContextColegio> options) : base(options)  //Constructor
        {

           
        }

        public DbSet<Asignatura> Asignaturas { get; set; } //Nuestro DbSet para representar nuestra tabla en la base de datos.

        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }

        public DbSet<Calificaciones> Calificaciones { get; set; }


    }
}
