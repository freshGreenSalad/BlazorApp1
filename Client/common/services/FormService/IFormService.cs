using BlazorApp1.Shared;

namespace BlazorApp1.Client.common.services.FormService
{
    public interface IFormService
    {
		public List<Form> formList { get; set; }

		public Form MainForm { get; set; }
		Task GetForms();

		Task GetMainForm();


		Task PostForms(Form form );

        Task setAsSentForm(int Id);

		Task DeleteForm(int Id);

	}
}
