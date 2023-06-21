using BlazorApp1.Shared;

namespace BlazorApp1.Client.features.addForm.services.questionservice
{
    public interface IQuestionService
    {
        List<Question> Questions { get; set; }

        Task GetQuestions();
    }
}
