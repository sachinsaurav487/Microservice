using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //get all employee frm dataacessLayer
            return new List<string> { "Account", "Admin", "Sales" };
        }
    }
}
