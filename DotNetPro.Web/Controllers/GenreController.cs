using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetPro.Infrastructure.Contract.Genre;
using DotNetPro.Infrastructure.Services.Genre;

namespace DotNetPro.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _service;

        public GenreController(IGenreService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(GenreCreateDto data)
        {
            var response = await _service.Create(data);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, GenreUpdateDto data)
        {
            var response = await _service.Update(id, data);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _service.Delete(id);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var response = await _service.Get(id);

            return Ok(response);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetList(int skip = 0, int take = 20)
        {
            var response = await _service.Query(x => true, skip, take);

            return Ok(response);
        }
    }
}
