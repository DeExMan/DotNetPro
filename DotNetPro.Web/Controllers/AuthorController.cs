﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetPro.Infrastructure.Contract.Author;
using DotNetPro.Infrastructure.Services.Author;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPro.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorCreateDto data)
        {
            var response = await _service.Create(data);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, AuthorUpdateDto data)
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
