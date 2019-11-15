using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingEFCore.Context;
using HandsOnAPIUsingEFCore.Models;
using HandsOnAPIUsingEFCore.Repository;

namespace HandsOnAPIUsingEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Employee/GetAll
        [HttpGet]
        [Route("GetAll")]
        public List<Employee> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Employee/GetById/1
       // [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public Employee Get(int id)
        {
            return _repository.GetByID(id);
        }

        // POST: api/Employee/Ad
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Employee item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Employee/Update/1
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(Employee item)
        {
            _repository.Update(item);
        }

        // DELETE: api/Employee/Delete/2
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
