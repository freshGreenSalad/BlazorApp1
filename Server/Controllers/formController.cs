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

		[HttpGet]
		public async Task<ActionResult<List<Form>>> GetAll()
		{
			return Ok(await _FormService.GetAll());
		}

		[HttpPost]
		public async Task put()
		{
			Console.WriteLine("in the form controller put block ");
			await _FormService.Put();
		}
	}
}
