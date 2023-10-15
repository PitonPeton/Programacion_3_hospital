using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Domain.Entities
{
	public class Prueba
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public ICollection<Resultado>? Resultados { get; set; }
	}
}
