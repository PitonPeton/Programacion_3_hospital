
using hospital.Application.ViewModels.Base;
using System.ComponentModel.DataAnnotations;

namespace hospital.Application.ViewModels.Medicos
{
	internal class SaveMedicosViewModel : SavePersonaViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "El correo es requerido")]
		public string Correo { get; set; }
	}
}
