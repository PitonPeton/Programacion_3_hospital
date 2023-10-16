
using System.ComponentModel.DataAnnotations;

namespace hospital.Application.ViewModels.Resultados
{
	public class SaveResultadoViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Se requiere la descripcion para el resultado")]
		public string Resultado_Final { get; set; }
		[Required(ErrorMessage = "Se necesita el estado del resultado")]
		public bool Completado { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Se requiere un paciente")]
		public int? Id_Paciente { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "Se requiere una prueba")]
		public int? Id_Prueba { get; set; }
	}
}
