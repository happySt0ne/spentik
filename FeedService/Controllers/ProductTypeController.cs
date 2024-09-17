using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Models;
using FeedService.Logic.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ProductTypeController : ControllerBase {
		private ICrudService<ProductType, ProductTypeDto> _crudService;

		public ProductTypeController(ICrudService<ProductType, ProductTypeDto> crudService) {
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
		public IActionResult Post(ProductType productType) { 
			if (productType == null) return BadRequest();

			_crudService.Create(productType);

			return Ok(productType);
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, ProductTypeDto productType) {
			if (productType == null) return BadRequest("There is no such product type");
			
			_crudService.Update(id, productType);

			return Ok(productType);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id) {
			_crudService.Delete(id);
			return Ok();
		}
	}
}
