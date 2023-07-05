using Microsoft.AspNetCore.Mvc;
using BlazorApp1.Shared;
using BlazorApp1.Server.Servces.FormService;
using BlazorApp1.Server.Controllers;

namespace BlazorApp1.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class formController : ControllerBase
	{

		private readonly IFormService _FormService;
		public formController(IFormService formService)
		{
			_FormService = formService;
		}

		[HttpGet(template:"getMainForm")]
		public async Task<ActionResult<Form>> GetMainForm()
		{
			var response = await _FormService.GetMainForm();
			Console.WriteLine(response.ToString());
			return Ok(response);
		}

		[HttpGet]
		public async Task<ActionResult<List<Form>>> GetAll()
		{
			return Ok(await _FormService.GetAll());
		}

		[HttpPost]
		public async Task put([FromBody]Form form)
		{
           await _FormService.Put(form);
		}
		
		[HttpPost(template: "setMainForm")]
		public async Task putMainForm([FromBody]int id)
		{
			Console.WriteLine("putMainForm controller");

			await _FormService.PutMainForm(id);
		}
	}
}
