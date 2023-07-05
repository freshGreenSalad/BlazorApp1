using BlazorApp1.Shared;
using System.Net.Http.Json;

namespace BlazorApp1.Client.common.services.FormService
{
    public class FormService : IFormService
    {
        public List<Form> formList { get; set; } = new List<Form>();
        public Form MainForm { get; set; } = new Form();

        private readonly HttpClient _http;

        public FormService(HttpClient http)
        {
            _http = http;
        }

        public List<Form> forms { get; set; } = new List<Form>();

		public async Task GetForms()
		{
			var respose = await _http.GetFromJsonAsync<List<Form>>("api/form");
			if (respose == null)
			{
				formList = new List<Form>();
			}
			else
			{
				formList = respose;
			}
		}
		public async Task GetMainForm()
		{
			var respose = await _http.GetFromJsonAsync<Form>("api/form/getMainForm");
			if (respose == null)
			{
				MainForm = new Form();
			}
			else
			{
				MainForm = respose;
			}
		}

		public async Task setAsSentForm(int Id) {
			Console.WriteLine("set as sent form");
            await _http.PostAsJsonAsync("api/form/setMainForm", Id);
        }

        public async Task PostForms(Form form)
        {
            await _http.PostAsJsonAsync("api/form", form);
        }
    }
}
