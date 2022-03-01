using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VI.Timesheets.API.Data;
using VI.Timesheets.API.Data.Implementation;
using VI.Timesheets.API.Data.Interfaces;
using VI.Timesheets.API.Models.Entities;

namespace VI.Timesheets.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepo _repository;
        public UserController (ILogger<UserController> logger, IUserRepo repository)
        {
            _logger = logger;
            _repository = repository;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User newUser )
        {
           await _repository.Add(newUser);
            return NoContent();
        }
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<User>> Get(int id)
        {
            if (await _repository.GetItem(id) == null)
            {
                return NotFound();
            }
            return Ok(await _repository.GetItem(id));
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] User user)
        {
            await _repository.Update(user);
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return NoContent();
        }
    }
}
