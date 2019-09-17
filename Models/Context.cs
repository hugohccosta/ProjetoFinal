using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    class Context : DbContext
    {

        public Context() : base("DbPaciente") { } //nome do banco de dados


        public DbSet<Paciente> Pacientes { get; set; }
        


    }
}
