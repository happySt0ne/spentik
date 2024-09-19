using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Models;
using FeedService.Logic.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ProductTypeController : CrudController<ProductType, ProductTypeDto> {
		public ProductTypeController(ICrudService<ProductType, ProductTypeDto> crudService) : base(crudService) {
		
		}
	}
}
