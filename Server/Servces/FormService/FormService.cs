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
			if (_context.Form == null)
			{
				return new List<Form>();
			}
			else
			{
				var Forms = await _context.Form
					.Include(a=> a.QuestionList)
					.ToListAsync();
				return Forms;
			}
		}

		public async Task<Form> GetMainForm()
		{
			var mainFormId = await _context.MainForm.FirstOrDefaultAsync();
			if (mainFormId == null)
			{
				return new Form();
			}
			else {
				var mainForm = _context.Form.Find(mainFormId.CurrentMainform);
				return mainForm;
			}
		}


		public async Task Put(Form form)
		{
            _context.Add(form);
			_context.SaveChanges();
		}

		public async Task PutMainForm(int id) {

			Console.WriteLine(id.ToString());

			var newMainForm = new mainform
			{
				CurrentMainform = id
			};

			if (_context.MainForm.Any())
			{
				Console.WriteLine("in if true");
				var rows = from o in _context.MainForm
						   select o;
				foreach (var row in rows)
				{
					_context.MainForm.Remove(row);
				}
				_context.SaveChanges();
				_context.MainForm.Add(newMainForm);
				_context.SaveChanges();
			}
			else {
				Console.WriteLine("in if else");

				_context.MainForm.Add(newMainForm);
				_context.SaveChanges();
			}
		}

		public async Task DeleteForm(int Id) {

			Console.WriteLine(Id.ToString());

			Form form = new Form() { ID = Id };
			_context.Form.Attach(form);
			_context.Form.Remove(form);
			_context.SaveChanges();
		}
	}
}
