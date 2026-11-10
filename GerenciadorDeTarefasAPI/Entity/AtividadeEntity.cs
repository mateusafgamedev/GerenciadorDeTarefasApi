using GerenciadorDeTarefasAPI.Entity.Enum;

namespace GerenciadorDeTarefasAPI.Entity
{
    public class AtividadeEntity
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Area { get; set; }
        public string Descricao { get; set; }
        public string? Detalhes { get; set; }
        public StatusAtividadeEnum StatusAtividade { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now;
        public DateTime? DataDeConclusao { get; set; }
        public DateTime DataDeInicio { get; set; }
        public TimeOnly? HorarioDeInicio { get; set; }
        public TimeOnly? HoraioDeFinalizacao { get; set; }
        public DiasDaSemanaEnum DiasDaSemana { get; set; }
    }
}
