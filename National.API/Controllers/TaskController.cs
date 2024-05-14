using Microsoft.AspNetCore.Mvc;
using National.Application.Interfaces;
using National.Domen.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace National.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Problem>>> GetAllTask()
        {
            var tasks = await _taskRepository.GetAllProblemAsync();
            return Ok(tasks);
        }

        // GET 
        [HttpGet("shortTitle")]
        public async Task<ActionResult<IEnumerable<Problem>>> GetAnyTask(string shortTitle)
        {
            var problems = await _taskRepository.GetAnyProblemAsync(shortTitle);
            if(problems != null)
            {
                return Ok(problems);
            }
            else
            {
                return BadRequest(problems);
            }
        }
    }
}
