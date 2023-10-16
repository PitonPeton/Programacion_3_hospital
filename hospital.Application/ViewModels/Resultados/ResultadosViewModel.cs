
namespace hospital.Application.ViewModels.Resultados
{
	public class ResultadosViewModel
	{
		public int Id { get; set; }
		public string Resultado_Final { get; set; }
		public bool Completado { get; set; }

		public int? Id_Paciente { get; set; }
		public int? Id_Prueba { get; set; }
	}
}
