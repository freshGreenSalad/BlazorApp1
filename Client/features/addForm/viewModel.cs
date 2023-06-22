
using BlazorApp1.Shared;
using BlazorApp1.Shared.questionTypes;

namespace BlazorApp1.Client.features.addForm
{
    public class viewModel
    {
        public List<Question> formOfQuestions = new List<Question>();

        public void addQuestionToForm(QuestionType quesitonType)
        {
            switch (quesitonType)
            {
                case QuestionType.TextQuestion:
                    formOfQuestions.Add(new TextQuestion
                    {
                        QuestionNumber = formOfQuestions.Count + 1
                    });
                    break;
                case QuestionType.NumberQuestion:
                    formOfQuestions.Add(new NumberQuestion
                    {
                        QuestionNumber = formOfQuestions.Count + 1
                    });
                    break;
                case QuestionType.MultiChoice:
                    formOfQuestions.Add(new MultiChoiceQuestion
                    {
                        QuestionNumber = formOfQuestions.Count + 1
                    });
                    break;
                case QuestionType.RadioQuestion:
                    formOfQuestions.Add(new RadionButtonQuestion
                    {
                        QuestionNumber = formOfQuestions.Count + 1
                    });
                    break;
                case QuestionType.BooleanQuestion:
                    formOfQuestions.Add(new BooleanQuesiton
                    {
                        QuestionNumber = formOfQuestions.Count + 1
                    });
                    break;
                default:
                    formOfQuestions.Add(new Question
                    {
                        QuestionNumber = formOfQuestions.Count + 1
                    });
                    break;
            }
        }

        public void UpdateQuestion(Question question)
        {
            formOfQuestions[question.QuestionNumber - 1] = question;
            writeListToConsole();
        }

        private void writeListToConsole()
        {
            foreach (Question question in formOfQuestions)
            {
                Console.WriteLine(question.ToString());
            }
        }
    }
}
