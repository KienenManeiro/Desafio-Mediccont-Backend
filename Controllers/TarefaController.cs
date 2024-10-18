using Mediccont.Models;
using Mediccont.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Mediccont.Controllers
{
    [ApiController]
    [Route("api/v1/tarefa")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepository;


        public TarefaController(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }


        [HttpPost]
        public IActionResult Add(TarefaViewModel tarefaView)
        {
            var tarefa = new Tarefa(tarefaView.tarefa, tarefaView.status, tarefaView.observacao, tarefaView.dataInicial);
            _tarefaRepository.Add(tarefa);
            return Ok(tarefa.id);//hot fix: enviando tarefa para poder coletar id no front 
        }


        [HttpGet]
        public IActionResult Get()
        {
            var tarefas = _tarefaRepository.Get();
            return Ok(tarefas);//retorna todas as tables
        }


        [HttpPut]
        public IActionResult Put(TarefaViewModel tarefaView)
        {
            var tarefa = new Tarefa(tarefaView.tarefa, tarefaView.status, tarefaView.observacao, tarefaView.dataInicial)
            {
                id = tarefaView.id
            };
            _tarefaRepository.Put(tarefa);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _tarefaRepository.Delete(id);
                return NoContent();//204
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);//404 
            }
        }
    }
}