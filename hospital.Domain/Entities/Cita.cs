using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Domain.Entities
{
	public class Cita
	{
		public int Id { get; set; }
		public DateTime Fecha_Hora { get; set; }
		public string Causa { get; set; }
		public string Estado { get; set; } //"pendiente de consulta", "pendiente de resusltados". "completada"

		public int Id_Paciente { get; set; }
		public int Id_Medico { get; set; }
		public Paciente Paciente { get; set; }
		public Medico Medico { get; set; }
		public ICollection<Resultado> Resultados { get; set; }
	}
}
