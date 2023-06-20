namespace BlazorApp1.Server.Servces.QuestionService
{
    public interface IQuestionService
    {
        Task<List<Question>> GetAll();
    }
}
