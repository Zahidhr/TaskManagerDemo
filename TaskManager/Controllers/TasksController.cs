using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;
using Task = TaskManager.Models.Task;

namespace TaskManager.Controllers
{
    [ApiController]
    [Route("api/Tasks")]
    public class TasksController : ControllerBase
    {
        private readonly TaskDbContext _context;
        public TasksController(TaskDbContext context) { _context = context; }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Task>>> GetTasks()
        {
            try
            {
                return await _context.Task.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the exception for further investigation
                _logger.LogError(ex, "An error occurred while retrieving tasks.");

                // Return a generic error message to the client
                return StatusCode(500, "An error occurred while retrieving tasks. Please try again later.");
            }
        }

    }
}