namespace MVC.Models
{
    public class Projeto
    {
        public int ProjetoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        public ICollection<Tarefa>? Tarefas { get; set; }
    }
}
