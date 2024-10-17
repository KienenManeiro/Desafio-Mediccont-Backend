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
                
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var tarefas = _tarefaRepository.Get();
            return Ok(tarefas);
        }

    }
}/*CS1729*/
