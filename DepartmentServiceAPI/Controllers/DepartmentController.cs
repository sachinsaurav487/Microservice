using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //get all departments
            return new List<string> { "Account","Admin","Sales"};
            //changes
        }
    }
}
