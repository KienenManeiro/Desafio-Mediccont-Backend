using Mediccont.Models;

namespace Mediccont.Infraestrutura
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Tarefa tarefa)
        {
            _context.Tarefa.Add(tarefa);
            _context.SaveChanges();
        }

        public List<Tarefa> Get()
        {
            return _context.Tarefa.ToList();
        }
    }
}
/*Cs0103*/