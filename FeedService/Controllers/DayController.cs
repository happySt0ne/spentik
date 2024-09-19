using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Models;
using FeedService.Logic.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class DayController : CrudController<Day, DayDto> {
		public DayController(ICrudService<Day, DayDto> crudService) : base(crudService) {

		}
	}
}
