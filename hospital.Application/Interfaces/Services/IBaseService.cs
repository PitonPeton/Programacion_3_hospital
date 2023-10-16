

namespace hospital.Application.Interfaces.Services
{
	public interface IBaseService<SaveViewModel, ViewModel>
		where SaveViewModel : class
		where ViewModel : class
	{
		Task Update(SaveViewModel viewModel);
		Task Add(SaveViewModel viewModel);
		Task Delete(SaveViewModel viewModel);
		Task<SaveViewModel> GetById(int id);
		Task<List<ViewModel>> GetAll();
	}
}
