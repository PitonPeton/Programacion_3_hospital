
using hospital.Application.ViewModels.Base;
using System.ComponentModel.DataAnnotations;

namespace hospital.Application.ViewModels.Pacientes
{
	public class SavePacienteViewModel : SavePersonaViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "La direccion es requerida")]
		public string Direccion { get; set; }
		[Required(ErrorMessage = "La fecha de nacimiento es requerida")]
		public DateTime Fecha_nacimiento { get; set; }
		[Required(ErrorMessage = "Esta informacion es requerida")]
		public bool EsFumador { get; set; }
		[Required(ErrorMessage = "Esta informacion es requerida")]
		public bool EsAlegico { get; set; }

	}
}
