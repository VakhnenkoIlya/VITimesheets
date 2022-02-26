using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using VI.TimeSheets.Repository;

namespace VI.Timesheets.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepositoryController : ControllerBase
    {

        private readonly ILogger<RepositoryController> _logger;
        private readonly IRepository _repository;

        public RepositoryController(ILogger<RepositoryController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet]
        [Route("name")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IReadOnlyCollection<Person>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetByName(string name)
        {
            if ((_repository.GetByName(name)).Count == 0)
            {
                return NotFound();
            }
            return Ok(_repository.GetByName(name));
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Person))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetById(int id)
        {
            if (_repository.GetById(id) == null)
            {
                return NotFound();
            }           
            return Ok(_repository.GetById(id));
        }

        [HttpGet]
        [Route("{skip}, {take}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IReadOnlyCollection<Person>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetPagination(int skip, int take)
        {
            if (_repository.GetPagination(skip, take).Count == 0)
            {
                return NotFound();
            }
            return Ok(_repository.GetPagination(skip, take));
        }

        [HttpPost]
        [Route("{person}")]
        public ActionResult AddPerson(Person person)
        {
            _repository.AddPerson(person);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeletePerson(int id)
        {
            _repository.DeletePerson(id);
            return Ok();
        }

        [HttpPut]
        [Route("{person}")]
        public ActionResult UpdatePersone(int id, string lastName, string email, string company)
        {
            _repository.UpdatePerson(_repository.GetById(id), lastName, email, company);
            return Ok();
        }
    }
}


