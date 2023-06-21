using BlazorApp1.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp1.Client.features.addForm.services.questionservice
{
    public class QuestionService : IQuestionService
    {

        private readonly HttpClient _http;

        public QuestionService(HttpClient http)
        {
            _http = http;
        }

        public List<Question> Questions { get; set; } = new List<Question>();

        //public async Task GetQuestions() => Questions = await _http.GetFromJsonAsync<List<Question>>("api/questions");

        public async Task GetQuestions()
        {
            var respose = await _http.GetFromJsonAsync<List<Question>>("api/questions");
            if (respose == null)
            {
                Questions = new List<Question>();
            }
            else
            {
                Questions = respose;
            }
        }
    }
}