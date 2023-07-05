using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class Question
    {
        [Required]
        [MaxLength(10000)]
        public string? question { get; set; }

        [Required]
        public int QuestionNumber { get; set; }

        [Required]
        public QuestionType QuestionType { get; set; }

        public int ID { get; set; }

        public List<IndividualMultichoiceQuestion> listOfMultiChoiceQuestions { get; set; } = new List<IndividualMultichoiceQuestion>();

    }
}
