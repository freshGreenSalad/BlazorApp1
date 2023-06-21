namespace BlazorApp1.Server.Servces.QuestionService
{
    public class QuestionService : IQuestionService
    {
        private readonly DataContext _context;
        public QuestionService(DataContext context) 
        { 
            _context = context;
        }

        public async Task<List<Question>> GetAll()
        {
            if (_context.Questions == null)
            {
                return new List<Question>();
            }
            else
            {
                var question = await _context.Questions.ToListAsync();
                return question;
            }
        }
    }
}
