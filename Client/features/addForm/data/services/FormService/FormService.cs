using BlazorApp1.Shared;
using System.Net.Http.Json;

namespace BlazorApp1.Client.features.addForm.data.services.FormService
{
	public class FormService : IFormService
	{
		public List<Form> form { get; set;}

		private readonly HttpClient _http;

		public FormService(HttpClient http)
		{
			_http = http;
		}

		public List<Form> forms { get; set; } = new List<Form>();

		public async Task GetForms()
		{
			var respose = await _http.GetFromJsonAsync<List<Form>>("api/forms");
			if (respose == null)
			{
				form = new List<Form>();
			}
			else
			{
				form = respose;
			}
		}

		public async Task PostForms()
		{
			Console.WriteLine("client post forms service ");

			await _http.PostAsync("api/form", null);
		}
	}
}
