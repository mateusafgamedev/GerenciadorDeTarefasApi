using Microsoft.AspNetCore.Identity;

namespace GerenciadorDeTarefasAPI.Entity
{
    public class UsuarioEntity : IdentityUser
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

    }
}
