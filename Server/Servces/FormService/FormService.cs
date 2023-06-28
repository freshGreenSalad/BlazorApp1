namespace BlazorApp1.Server.Servces.FormService
{
	public class FormService : IFormService
	{

		private readonly DataContext _context;
		public FormService(DataContext context)
		{
			_context = context;
		}
		public async Task<List<Form>> GetAll()
		{
			if (_context.Forms == null)
			{
				return new List<Form>();
			}
			else
			{
				var Forms = await _context.Forms
					.Include(a=> a.QuestionList)
					.ToListAsync();
				return Forms;
			}
		}

		public async Task Put(Form form)
		{
			Console.WriteLine("in the form service put block ");

			_context.Add(form);
			_context.SaveChanges();
		}
	}
}
