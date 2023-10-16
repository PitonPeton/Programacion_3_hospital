
using hospital.Application.ViewModels.Base;

namespace hospital.Application.ViewModels.Pacientes
{
    public class PacienteViewModel : PersonaViewModel
	{
		public int Id { get; set; }
		public string Direccion { get; set; }
		public DateTime Fecha_nacimiento { get; set; }
		public bool EsFumador { get; set; }
		public bool EsAlegico { get; set; }

	}
}
