namespace MVC.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }
        public string Titulo {  get; set; }
        public string Descricao { get; set; }
        public string StatusTarefa { get; set; }

        public int ProjetoId { get; set; }
        public Projeto? Projeto { get; set; }
        //contendo um identificador, título, descrição, status da tarefa e a referência ao projeto ao qual está vinculada.
    }
}
