namespace Mediccont.Models
{
    public interface ITarefaRepository
    {
        void Add(Tarefa tarefa);


        List<Tarefa> Get();
    }
}
