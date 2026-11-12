using GerenciadorDeTarefasAPI.Entity.Enum;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace GerenciadorDeTarefasAPI.Entity
{
    public class AtividadeEntity
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string? Detalhes { get; set; }
        public StatusAtividadeEnum StatusAtividade { get; set; } = StatusAtividadeEnum.NaoIniciada;
        public DateTime DataDeCriacao { get; set; } = DateTime.Now;
        public DateTime? DataDeConclusao { get; set; }
        public DateTime? DataDeInicio { get; set; }
        public TimeOnly? HorarioDeInicio { get; set; }
        public TimeOnly? HorarioDeFinalizacao { get; set; }
        public DiasDaSemanaEnum DiasDaSemana { get; set; }
        public Guid UsuarioId { get; set; }
        public UsuarioEntity Usuario { get; set; } = null!;
    }
}
