namespace BlazorApp1.Server.Servces.FormService
{
	public interface IFormService
	{

		Task<List<Form>> GetAll();

		Task Put();
	}
}
