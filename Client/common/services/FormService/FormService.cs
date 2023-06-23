using BlazorApp1.Shared;
using System.Net.Http.Json;

namespace BlazorApp1.Client.common.services.FormService
{
    public class FormService : IFormService
    {
        public List<Form> formList { get; set; }

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
                formList = new List<Form>();
            }
            else
            {
                formList = respose;
            }
        }

        public async Task PostForms()
        {
            Console.WriteLine("client post forms service ");

            await _http.PostAsync("api/form", null);
        }
    }
}
