namespace Mediccont.ViewModel
{
    public class TarefaViewModel
    {
     public int id { get; private set; }
     public string tarefa { get; private set; }
     public string status { get; private set; }
     public string observacao { get; private set; }
     public DateTime dataInicial { get; private set; }

        public TarefaViewModel(string tarefa, string status, string observacao, DateTime dataInicial)/*CS1520*/
        {
            this.tarefa = tarefa ?? throw new ArgumentNullException(nameof(tarefa));
            this.status = status;
            this.observacao = observacao;
            this.dataInicial = dataInicial;
        }
    }
}
