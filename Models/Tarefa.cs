using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mediccont.Models
{
    //BDD tabela Tarefa
    [Table("Tarefa")]
    public class Tarefa
    {
        [Key]
        public int id { get; set; }

        public string tarefa { get; private set; }
        public string status { get; private set; }
        public string observacao { get; private set; }
        public DateTime dataInicial { get; private set; }

        //construtor PADRÃO EF Core n remover
        public Tarefa() { }

        public Tarefa(string tarefa, string status, string observacao, DateTime dataInicial)
        {
            this.tarefa = tarefa ?? throw new ArgumentNullException(nameof(tarefa));
            this.status = status;
            this.observacao = observacao;
            this.dataInicial = dataInicial;
        }

        public void Update(int id, string tarefa, string status, string observacao, DateTime dataInicial)
        {
            this.id = id;
        }
    }
}