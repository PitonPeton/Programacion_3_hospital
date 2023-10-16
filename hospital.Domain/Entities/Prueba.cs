
namespace hospital.Domain.Entities
{
	public class Prueba
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public ICollection<Resultado>? Resultados { get; set; }
	}
}
