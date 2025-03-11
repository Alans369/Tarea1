using Microsoft.EntityFrameworkCore;

namespace PruebaCodefirst.Models
{
    public class MiContext: DbContext
    {

        public MiContext(DbContextOptions<MiContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Empleado> Empleados { get; set; }




    }
}
