using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Models;
using FeedService.Logic;
using FeedService.Logic.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class DayProductController : ControllerBase {
		private ICrudService<DayProduct, DayProductDto> _crudService;

		public DayProductController(ICrudService<DayProduct, DayProductDto> crudService) {
			_crudService = crudService;
		}

		[HttpGet]
		public IActionResult Get() {
			return Ok(_crudService.Get());
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id) {
			return Ok(_crudService.Get(id));
		}

		[HttpPost]
		public IActionResult Post(DayProduct dayProduct) {
			_crudService.Create(dayProduct);
			return Ok(dayProduct);
		}

		[HttpDelete]
		public IActionResult Delete(int id) {
			_crudService.Delete(id);
			return Ok();
		}

		[HttpPut]
		public IActionResult Put(int id, DayProductDto dayProduct) {
			if (dayProduct is null) return BadRequest("null given while updating");

			_crudService.Update(id, dayProduct);

			return Ok();
		}
	}
}
