using GerenciadorDeTarefasAPI.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefasAPI.Data
{
    public class AppDbContext : IdentityDbContext<UsuarioEntity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<AtividadeEntity> Atividades { get; set; }
    }
}
