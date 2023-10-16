
using System.ComponentModel.DataAnnotations;

namespace hospital.Application.ViewModels.Pruebas
{
	public class SavePruebaViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "El nombre es requerido")]
		public string Nombre { get; set; }
	}
}
