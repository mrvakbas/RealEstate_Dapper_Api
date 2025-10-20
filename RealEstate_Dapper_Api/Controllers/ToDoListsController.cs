using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ToDoListRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ToDoListsController : ControllerBase
	{
		private readonly ITodoListRepository _todoListRepository;

		public ToDoListsController(ITodoListRepository todoListRepository)
		{
			_todoListRepository = todoListRepository;
		}

		[HttpGet]
		public async Task<IActionResult> ToDoListList()
		{
			var values = await _todoListRepository.GetAllToDoList();
			return Ok(values);
		}
	}
}
