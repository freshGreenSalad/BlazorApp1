using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class Question
    {
        public string? question { get; set; }

        public int QuestionNumber { get; set; }

        public QuestionType questionType { get; set; }

        public int ID { get; set; }
    }
}
