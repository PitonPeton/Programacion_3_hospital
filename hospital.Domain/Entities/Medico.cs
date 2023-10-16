using hospital.Domain.Base;

namespace hospital.Domain.Entities
{
	public class Medico : Persona
	{
		public int Id { get; set; }
		public string Correo { get; set; }

		public ICollection<Cita>? Citas { get; set; }
	}
}
