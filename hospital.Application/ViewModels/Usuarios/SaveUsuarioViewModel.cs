
using System.ComponentModel.DataAnnotations;

namespace hospital.Application.ViewModels.Usuarios
{
	public class SaveUsuarioViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "El nombre es requerido")]
		public string Nombre { get; set; }
		[Required(ErrorMessage = "El apellido es requerido")]
		public string Apellido { get; set; }
		[Required(ErrorMessage = "El correo es requerido")]
		public string Correo { get; set; }
		[Required(ErrorMessage = "Ingrese un nombre de usuario")]
		public string Nombre_Usuario { get; set; }
		[Required(ErrorMessage = "Ingrese una contraseña")]
		public string Contraseña { get; set; }
		[Required(ErrorMessage = "Se requiere un tipo de usuario")]
		public bool Tipo_Usuario { get; set; }
	}
}
