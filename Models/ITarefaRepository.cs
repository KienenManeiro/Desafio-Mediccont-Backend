using System.Collections.Generic;

namespace Mediccont.Models
{
    public interface ITarefaRepository
    {
        void Add(Tarefa tarefa);        
        

        List<Tarefa> Get();          

        
        void Put(Tarefa tarefa);   
        

        void Delete(int id);                    
    }
}