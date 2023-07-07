using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Servces.FormService
{
	public interface IFormService
	{
		Task<List<Form>> GetAll();
		Task<Form> GetMainForm();
		Task Put (Form form);
        Task PutMainForm (int id);

		Task DeleteForm(int Id);
	}
}
