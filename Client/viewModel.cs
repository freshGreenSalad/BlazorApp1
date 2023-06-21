using BlazorApp1.Shared;

namespace BlazorApp1.Client
{
    public class viewModel
    {
        public List<Question> formOfQuestions = new List<Question>();

        public List<string> questionList = new List<string>();
        

        public string? questionBeingAdded { get; set; }

        public void addQuestionToForm() { 
            formOfQuestions.Add(new Question { 
                ID = 1,
                question = "asdf"
            });
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
