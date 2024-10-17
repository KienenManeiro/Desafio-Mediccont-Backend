using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Mediccont.Models
{
    [Table("Tarefa")]
    public class Tarefa
    {
        [Key]
        public int id { get; private set; }
        public string tarefa { get; private set; }
        public string status { get; private set; }
        public string observacao { get; private set; }
        public DateTime dataInicial {  get; private set; }


        public Tarefa(string tarefa, string status, string observacao, DateTime dataInicial)
        {
            this.tarefa = tarefa ?? throw new ArgumentNullException(nameof(tarefa));
            this.status = status;
            this.observacao = observacao;
            this.dataInicial= dataInicial;
        }
    }

    
}
