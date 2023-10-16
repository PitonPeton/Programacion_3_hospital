
using System.ComponentModel.DataAnnotations;

namespace hospital.Application.ViewModels.Citas
{
	public class SaveCitaViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Se requiere una fecha para la cita")]
		public DateTime Fecha_Hora { get; set; }
		[Required(ErrorMessage = "Se requiere una causa para la cita")]
		public string Causa { get; set; }
		[Required(ErrorMessage = "Se requiere un estado para la cita")]
		public string Estado { get; set; } //"pendiente de consulta", "pendiente de resusltados". "completada"

		[Range(1, int.MaxValue, ErrorMessage = "Se requiere un paciente para la cita")]
		public int? Id_Paciente { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "Se requiere un medico para la cita")]
		public int? Id_Medico { get; set; }
	}
}
