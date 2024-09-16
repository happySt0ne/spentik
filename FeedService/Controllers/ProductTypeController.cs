using FeedService.DataLayer;
using FeedService.DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ProductTypeController : ControllerBase {
		private FinlahContext _context;

		public ProductTypeController(FinlahContext context) {
			_context = context;
		}

		[HttpGet]
		public IActionResult Get() {
			return Ok(_context.ProductTypes);
		}

		[HttpPost]
		public IActionResult Post(ProductType productType) { 
			if (productType == null) return BadRequest();

			_context.ProductTypes.Add(productType);
			_context.SaveChanges();

			return Ok(productType);
		}
	}
}
