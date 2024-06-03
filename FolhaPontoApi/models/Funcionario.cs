using System.ComponentModel.DataAnnotations;

namespace FolhaPontoApi.models
{
    public class Funcionario
    {
        [Key]
        public int Id{get;set;}
        public string Nome{get;set;}
        public string Cargo{get;set;}
        public DateTime DataContratacao{get;set;}

        public ICollection<Horario> Horarios{get;set;}
    }
}