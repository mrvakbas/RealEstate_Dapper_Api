using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepository;
using System.Threading.Tasks;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductsController : ControllerBase
    {
        private readonly ILast5ProductsRepository _last5ProduuctsRepository;

        public EstateAgentLastProductsController(ILast5ProductsRepository last5ProduuctsRepository)
        {
            _last5ProduuctsRepository = last5ProduuctsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLast5ProductAsync(int id)
        {
            var values = await _last5ProduuctsRepository.GetLast5ProductAsync(id);
            return Ok(values);
        }
	}
}
