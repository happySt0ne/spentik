using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Models;
using FeedService.Logic;
using FeedService.Logic.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class DayProductController : CrudController<DayProduct, DayProductDto> {
		
		public DayProductController(ICrudService<DayProduct, DayProductDto> crudService) : base(crudService) {

		}

	}
}
