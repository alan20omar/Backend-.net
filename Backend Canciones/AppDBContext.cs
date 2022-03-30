using Backend_Canciones.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Canciones
{
    public class AppDBContext: DbContext
    {
        public DbSet<User> User { get; set; } // Tabla en base de datos

        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }
    }
}
