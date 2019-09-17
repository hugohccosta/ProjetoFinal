
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal.Models
{
    [Table("Pacientes")]
    class Paciente
    {
        public Paciente() {

        }
        [Key]
        public int PacienteId { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int Idade { get; set; }

        public string Telefone { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }
        
    }
}
