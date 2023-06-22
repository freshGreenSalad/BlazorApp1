namespace BlazorApp1.Client.features.addForm.data.services.FormService
{
	public interface IFormService
	{
		Task GetForms();

		Task PostForms();
	}
}
