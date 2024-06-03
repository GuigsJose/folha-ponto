using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FolhaPontoApi.models
{
    public class Horario
    {
        [Key]
        public int Id{get;set;}

        [ForeignKey("Funcionario")]
        public int FuncionarioId{get;set;}
        public DateTime HoraEntrada{get;set;}
        public DateTime HoraSaida{get;set;}
        public Funcionario Funcionario{get;set;}
    }
}