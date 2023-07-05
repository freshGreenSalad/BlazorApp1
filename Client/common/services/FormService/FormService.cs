using BlazorApp1.Shared;
using System.Net.Http.Json;

namespace BlazorApp1.Client.common.services.FormService
{
    public class FormService : IFormService
    {
        public List<Form> formList { get; set; } = new List<Form>();

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

        public async Task setAsSentForm(int Id) {
            await _http.PostAsJsonAsync("api/form", Id);
        }

        public async Task PostForms(Form form)
        {

			Console.WriteLine("client post forms service, client ");
            Console.WriteLine(form.QuestionList[0].listOfMultiChoiceQuestions.Count().ToString());
            foreach (var question in form.QuestionList[0].listOfMultiChoiceQuestions) {
                Console.WriteLine(question);
            }

            var result = await _http.PostAsJsonAsync("api/form", form).ConfigureAwait(false);

            Console.WriteLine(result.StatusCode.ToString());
        }
    }
}
