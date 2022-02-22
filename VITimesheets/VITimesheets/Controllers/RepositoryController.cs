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

        public List<Person> GetAll()
        {
            return _repository.GetAll();
        }



        [HttpGet]
        [Route("name")]
        public List<Person> GetByName(string name)
        {
            return _repository.GetByName(name);
        }
        [HttpGet]
        [Route("{id}")]
        public Person GetById(int id)
        {
            return _repository.GetById(id);
        }
        [HttpGet]
        [Route("{skip}, {take}")]
        public List<Person> GetPaginationC(int skip, int take)
        {
            return _repository.GetPagination(skip, take);
        }
        [HttpPost]
        [Route("{person}")]
        public void AddPerson(Person person)
        {
            _repository.AddPerson(person);
        }
        [HttpDelete]
        [Route("{id}")]
        public void DeletePerson(int id)
        {
            _repository.DeletePerson(id);
        }
        [HttpPut]
        [Route("{person}, lastName, ")]
        public void UpdatePersone(int id, string lastName, string email, string company)
        {
            _repository.UpdatePerson(GetById(id), lastName, email, company);
        }
    }
}


