using System.ComponentModel.DataAnnotations;

namespace hospital.Application.ViewModels.Base
{
	public class SavePersonaViewModel
	{
		[Required(ErrorMessage = "El nombre es requerido")]
		public string Nombre { get; set; }
		[Required(ErrorMessage = "El apellido es requerido")]

		public string Apellido { get; set; }
		[Required(ErrorMessage = "El telefono es requerido")]

		public string Telefono { get; set; }
		[Required(ErrorMessage = "Ingrese una foto")]

		public string Foto { get; set; }
		[Required(ErrorMessage = "La cedula es requerida")]

		public string Cedula { get; set; }
	}
}
