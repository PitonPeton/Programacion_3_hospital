using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Domain.Entities
{
	public class Resultado
	{
		public int Id { get; set; }
		public string Resultado_Final { get; set; }
		public bool Completado { get; set; }

		public int? Id_Paciente { get; set; }
		public int? Id_Prueba { get; set; }
		public Paciente? Paciente { get; set; }
		public Prueba? Prueba { get; set; }
	}
}
