using System;
using System.Collections.Generic;
using System.Linq;
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


        public void Put(Tarefa tarefa)
        {
            try
            {
                _context.Tarefa.Update(tarefa);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Erro ao atualizar a tarefa.", ex);
            }
        }


        public void Delete(int id)
        {
            var tarefa = _context.Tarefa.Find(id);//encontra pelo ID
            if (tarefa != null)
            {
                _context.Tarefa.Remove(tarefa);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
    }
}