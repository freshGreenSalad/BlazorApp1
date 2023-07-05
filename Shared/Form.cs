using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
	public class Form
	{
		public int ID { get; set; }
		public string name { get; set; }
		public string dateCreated { get; set; }
		public List<Question>? QuestionList { get; set; } = new List<Question>();
	}
}
