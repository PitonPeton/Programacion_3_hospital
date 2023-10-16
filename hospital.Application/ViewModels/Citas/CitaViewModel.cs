
namespace hospital.Application.ViewModels.Cita
{
	public class CitaViewModel
	{
		public int Id { get; set; }
		public DateTime Fecha_Hora { get; set; }
		public string Causa { get; set; }
		public string Estado { get; set; } //"pendiente de consulta", "pendiente de resusltados". "completada"

		public int? Id_Paciente { get; set; }
		public int? Id_Medico { get; set; }
	}
}
