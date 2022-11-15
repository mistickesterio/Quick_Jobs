using Backend.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VagasController : ControllerBase
	{
		[HttpGet]
		public IActionResult Listar()
		{
			var dao = new VagasDAO();
			var vagas = dao.ListarVagas();

			return Ok(vagas);
		}
	}
}
