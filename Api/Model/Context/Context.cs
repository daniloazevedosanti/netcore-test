using Microsoft.EntityFrameworkCore;

namespace Api.Model.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Medic> Medicos { get; set; }
        public DbSet<Patient> Pacientes { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Consultation> Consultas { get; set; }
    }
}
