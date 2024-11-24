using Microsoft.EntityFrameworkCore;
using GestionCrud.Models;



namespace GestionCrud.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
