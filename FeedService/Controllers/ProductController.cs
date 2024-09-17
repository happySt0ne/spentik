using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Models;
using FeedService.Logic.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase {
		private ICrudService<Product, ProductDto> _crudService;

		public ProductController(ICrudService<Product, ProductDto> crudService) {
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
		public IActionResult Post(Product product) {
			if (product is null) return BadRequest("product is null!");
			
			_crudService.Create(product);

			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id) {
			_crudService.Delete(id);
			return Ok();
		}

		[HttpPut]
		public IActionResult Put(int id, ProductDto product) {
			if (product is null) return BadRequest("product is null!");

			_crudService.Update(id, product);

			return Ok();
		}
	}
}
