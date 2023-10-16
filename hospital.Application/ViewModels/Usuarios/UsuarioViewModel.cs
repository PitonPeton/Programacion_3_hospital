
namespace hospital.Application.ViewModels.Usuarios
{
	public class UsuarioViewModel
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Correo { get; set; }
		public string Nombre_Usuario { get; set; }
		public string Contraseña { get; set; }

		// Tipo_Usuario = false para Asistente
		// Tipo_Usuario = true para Administrador
		public bool Tipo_Usuario { get; set; }
	}
}
