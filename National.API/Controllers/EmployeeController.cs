using Microsoft.AspNetCore.Mvc;
using National.Application.Interfaces;
using National.Domen.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace National.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult<Employee>> Get(string guid)
        {
            return await _repository.GetEmployee(guid);
        }
    }
}
