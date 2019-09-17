using ProjetoFinal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ProjetoFinal.DAL
{
    class PacienteDao
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarPaciente (Paciente p)
        {
            ctx.Pacientes.Add(p);
            ctx.SaveChanges();
        }
        //TODO: Add parameter in Include to make relatioship between classes 
        public static List<Paciente> ListarPaciente() => ctx.Pacientes.Include("Medico").ToList();
        public static Paciente BuscarPacientePorNome(Paciente p)
        {
            return ctx.Pacientes.FirstOrDefault(x => x.Nome.Equals(p.Nome));
        }
        public static List<Paciente> BucarPacientePorParteNome(Paciente p)
        {
            return ctx.Pacientes.Where(x => x.Nome.Contains(p.Nome)).ToList();
        }
        public static void RemoverPaciente(Paciente p)
        {
            ctx.Pacientes.Remove(p);
            ctx.SaveChanges();
        }
        public static void AlterarPaciente(Paciente p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
