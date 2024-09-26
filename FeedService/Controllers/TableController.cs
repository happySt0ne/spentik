using FeedService.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class TableController : ControllerBase {
		private IMonthTableService _monthTableService;

		public TableController(IMonthTableService monthTableService) {
			_monthTableService = monthTableService;
		}

		[HttpGet("{date}")]
		public IActionResult Get(DateOnly date) {
			return Ok(_monthTableService.GetTable(date.Year, date.Month));
		}
	}
}
