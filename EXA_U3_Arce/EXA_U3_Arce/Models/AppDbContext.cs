using System.Data.Entity;

namespace EXA_U3_Arce.Models
{
    public class AppDbContext : DbContext
    {
        static AppDbContext()
        {
            // Desactiva la inicialización automática para evitar que EF cree o modifique la base de datos
            Database.SetInitializer<AppDbContext>(null);
        }
        public AppDbContext() : base("name=AppDbContext") { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
