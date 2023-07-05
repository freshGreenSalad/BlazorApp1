
using BlazorApp1.Shared;

namespace BlazorApp1.Client.features.addForm
{
    public class viewModel
    {
        public List<Question> formOfQuestions = new List<Question>();

        public string formName { get; set; }
        public string formDateCreated { get; set; }

        public void addQuestionToForm(QuestionType quesitonType)
        {
            formOfQuestions.Add(
                new Question
                {
                    QuestionNumber = formOfQuestions.Count + 1,
                    QuestionType = quesitonType,
                }
            );
        }

        public void UpdateQuestion(Question question)
        {
            formOfQuestions[question.QuestionNumber - 1] = question;
            writeListToConsole();
        }

        public void updateTitle(string title)
        {
            formName = title;
        }

        private void writeListToConsole()
        {
            foreach (Question question in formOfQuestions)
            {
                Console.WriteLine(question.ToString());
            }
        }

        public  Form buildForm() {
            return new Form
            {
                name = formName,
                dateCreated = DateTime.Now.ToString("MM / dd / yyyy"),
                QuestionList = formOfQuestions,
            };
        }
    }
}
