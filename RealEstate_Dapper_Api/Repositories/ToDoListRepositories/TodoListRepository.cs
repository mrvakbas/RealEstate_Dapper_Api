using Dapper;
using RealEstate_Dapper_Api.Dtos.ToDoListDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ToDoListRepositories
{
	public class TodoListRepository : ITodoListRepository
	{
		private readonly Context _context;

		public TodoListRepository(Context context)
		{
			_context = context;
		}

		public async Task<List<ResultToDoListDto>> GetAllToDoList()
		{
			string query = "Select * From ToDoList";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultToDoListDto>(query);
				return values.ToList();
			}
		}

		public Task CreateToDoList(CreateToDoListDto ToDoListDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteToDoList(int id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateToDoList(UpdateToDoListDto ToDoListDto)
		{
			throw new NotImplementedException();
		}

		public Task<GetByIDToDoListDto> GetToDoList(int id)
		{
			throw new NotImplementedException();
		}
	}
}
