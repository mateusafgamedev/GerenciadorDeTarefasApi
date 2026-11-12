using GerenciadorDeTarefasAPI.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefasAPI.Data
{
    public class AppDbContext : IdentityDbContext<UsuarioEntity, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

        public DbSet<AtividadeEntity> Atividades => Set<AtividadeEntity>();

        
    }
}
