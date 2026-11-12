using Microsoft.AspNetCore.Identity;

namespace GerenciadorDeTarefasAPI.Entity
{
    public class UsuarioEntity : IdentityUser<Guid>
    {
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public TimeOnly? PeriodoDeAtividadeInicio { get; set; }
        public TimeOnly? PeriodoDeAtividadeFim { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;
        public List<AtividadeEntity> Atividades { get; set; } = new();

    }
}
