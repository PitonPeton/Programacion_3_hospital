using hospital.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Domain.Entities
{
	public class Medico : Persona
	{
		public int Id { get; set; }
		public string Correo { get; set; }
	}
}
