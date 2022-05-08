using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {

        }

        [HttpGet("Get Students")]
        public IActionResult GetStudents()
        {
            return Ok(new List<string>
            {
                "Student1",
                "Student2"
            });
        }
    }
}
