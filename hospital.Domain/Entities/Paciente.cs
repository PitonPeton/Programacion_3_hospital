using hospital.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Domain.Entities
{
	public class Paciente : Persona
	{
		public int Id { get; set; }
		public string Direccion { get; set; }
		public DateOnly Fecha_nacimiento { get; set; }
		public bool EsFumador { get; set; }
		public bool EsAlegico { get; set; }

		public ICollection<Cita> Citas { get; set; }
	}
}
