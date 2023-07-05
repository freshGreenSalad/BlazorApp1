using BlazorApp1.Shared;

namespace BlazorApp1.Client.common.services.FormService
{
    public interface IFormService
    {
		public List<Form> formList { get; set; }
		Task GetForms();

        Task PostForms(Form form );

        Task setAsSentForm(int Id);

	}
}
