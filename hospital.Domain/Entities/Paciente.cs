﻿using hospital.Domain.Base;

namespace hospital.Domain.Entities
{
	public class Paciente : Persona
	{
		public int Id { get; set; }
		public string Direccion { get; set; }
		public DateTime Fecha_nacimiento { get; set; }
		public bool EsFumador { get; set; }
		public bool EsAlegico { get; set; }

		public ICollection<Cita>? Citas { get; set; }
		public ICollection<Resultado>? Resultados { get; set; }
	}
}
