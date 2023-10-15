using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Domain.Entities
{
	public class Usuario
	{
		public int Id_Usuario { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Correo { get; set; }
		public string Nombre_Usuario { get; set; }
		public string Contraseña { get; set; }

		// Tipo_Usuario = false para Asistente
		// Tipo_Usuario = true para Administrador
		public bool Tipo_Usuario { get; set; }
	}
}
