using hospital.Application.ViewModels.Base;

namespace hospital.Application.ViewModels.Medicos
{
    public class MedicoViewModel : PersonaViewModel
    {
        public int Id { get; set; }
        public string Correo { get; set; }
    }
}
