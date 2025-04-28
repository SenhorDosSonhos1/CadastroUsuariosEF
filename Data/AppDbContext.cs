using Microsoft.EntityFrameworkCore;
using CadastroUsuariosEF.Models;

namespace CadastroUsuariosEF.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }
        
        public DbSet<Usuario> Usuarios { get; set; }
    }
}