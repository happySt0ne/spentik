using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Interfaces;
using FeedService.DataLayer.Models;
using FeedService.Logic.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FeedService.Controllers {
	public class CrudController<T, dtoT> : ControllerBase 
	where T: class, ITable
	where dtoT: IDto<T, dtoT> {
		private ICrudService<T, dtoT> _crudService;

		public CrudController(ICrudService<T, dtoT> crudService) {
			_crudService = crudService;
		}

		[HttpGet]
		public virtual IActionResult Get() {
			return Ok(_crudService.Get());
		}

		[HttpGet("{id}")]
		public virtual IActionResult Get(int id) {
			return Ok(_crudService.Get(id));
		}

		[HttpPost]
		public virtual IActionResult Post(T item) {
			_crudService.Create(item);
			return Ok(item);
		}

		[HttpDelete]
		public virtual IActionResult Delete(int id) {
			_crudService.Delete(id);
			return Ok();
		}

		[HttpPut]
		public virtual IActionResult Put(int id, dtoT dto) {
			if (dto is null) return BadRequest("null given while updating");

			_crudService.Update(id, dto);

			return Ok();
		}

	}
}
