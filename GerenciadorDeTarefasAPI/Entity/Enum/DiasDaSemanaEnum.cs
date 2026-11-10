namespace GerenciadorDeTarefasAPI.Entity.Enum
{
    [Flags]
    public enum DiasDaSemanaEnum
    {
        Nenhum = 0,
        Segunda = 1,
        Terca = 2,
        Quarta = 4,
        Quinta = 8,
        Sexta = 16,
        Sabado = 32,
        Domingo = 64
    }
}
