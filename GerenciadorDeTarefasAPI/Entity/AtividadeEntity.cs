using GerenciadorDeTarefasAPI.Entity.Enum;

namespace GerenciadorDeTarefasAPI.Entity
{
    public class AtividadeEntity
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string? Detalhes { get; set; }
        public SituacaoAtividadeEnum SituacaoAtividade { get; set; } = SituacaoAtividadeEnum.NaoIniciada;
        public DateTime DataDeCriacao { get; set; } = DateTime.Now;
        public DateTime? DataDeConclusao { get; set; }
        public DateTime? DataDeInicio { get; set; }
        public TimeOnly? HorarioDeInicio { get; set; }
        public TimeOnly? HorarioDeFinalizacao { get; set; }
        public DiasDaSemanaEnum DiasDaSemana { get; set; }
        public Guid UsuarioId { get; set; }
        public UsuarioEntity Usuario { get; set; } = null!;
        public NaturezaAtividadeEnum NaturezaAtividade { get; set; }
    }
}
