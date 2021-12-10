using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> CreateStudent(Student obj)
        {
            // you code here
            return "Data inserted successfully";
        }
        
    }
}
