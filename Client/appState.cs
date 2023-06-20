namespace BlazorApp1.Client
{
    public class appState
    {
        public List<string> questionList = new List<string>();

        public string? questionBeingAdded { get; set; }

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
