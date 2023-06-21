using BlazorApp1.Shared;
using BlazorApp1.Shared.questionTypes;

namespace BlazorApp1.Client
{
    public class viewModel
    {
        public List<Question> formOfQuestions = new List<Question>();

        public List<string> questionList = new List<string>();
        

        public string? questionBeingAdded { get; set; }

        public void addQuestionToForm(QuestionType quesitonType) {
        switch (quesitonType)
            {
                case QuestionType.TextQuestion:
                    formOfQuestions.Add(new TextQuestion
                    {
                        QuestionNumber = formOfQuestions.Count + 1
                    }); ;
                    break;
                case QuestionType.NumberQuestion:
                    formOfQuestions.Add(new NumberQuestion());
                    break;
                case QuestionType.MultiChoice:
                    formOfQuestions.Add(new MultiChoiceQuestion());
                    break;
                case QuestionType.RadioQuestion:
                    formOfQuestions.Add(new RadionButtonQuestion());
                    break;
                case QuestionType.BooleanQuestion:
                    formOfQuestions.Add(new BooleanQuesiton());
                    break;
                default:
                    formOfQuestions.Add(new Question());
                    break;
            }
        }
            
        public void removeQuestionFromList(string questionToRemove)
        {
           
            questionList.Remove(questionToRemove);
        }

        public void addQuestion(string questionToAdd)
        {
            if (questionToAdd == "no val" || questionToAdd == "")
            {
                return;
            }
            questionBeingAdded = questionToAdd;
            questionList.Add(questionToAdd);
            questionBeingAdded = "";
        }

        public void OnChange(string value, string name)
        {
            Console.WriteLine(value);
        }

    }
}
